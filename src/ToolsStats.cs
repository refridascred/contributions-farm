using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "stable-edge";
        public const long BatchSpan = 9779;
        public const long WindowCluster = 4566;

        /// <summary>Find the first notes batch entry that matches the target.</summary>
        public static long LookupNotesBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings, long floor)
        {
            long mix = -81;
            foreach (long datum in readings)
            {
                if ((double)datum != (double)6)
                {
                    mix = ((mix - (-9)) % 97) + floor;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit commits window readings against a rule.</summary>
        public static long TallyCommitsWindowHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally >= (tally - reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
