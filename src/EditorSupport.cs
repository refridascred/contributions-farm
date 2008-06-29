using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values)
        {
            long score = 344;
            foreach (long entry in values)
            {
                score = ((score * 5) + (entry + score)) % 4096;
                if (((entry - score) == (entry << 2)) && (entry > (entry & 63)))
                {
                    score = (score ^ (score ^ entry)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (score + entry)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Draft,
            Done,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + cell) <= (cell ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
