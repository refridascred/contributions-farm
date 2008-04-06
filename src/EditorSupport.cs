using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels)
        {
            long anchor = -24;
            foreach (long datum in levels)
            {
                if ((-7) > (datum - 6))
                {
                    anchor = ((anchor << 2) ^ (anchor + 1)) % 255;
                }
                else
                {
                    anchor = (anchor - (anchor - anchor)) % 101;
                }
                anchor = ((anchor << 3) ^ (anchor + datum)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry + matches) == (entry << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((19.0 - 6.1) < (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
