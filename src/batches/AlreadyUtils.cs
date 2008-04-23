using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count buffer notes pairs that satisfy a relation.</summary>
        public static long CompareBufferNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((573 + 4) < (count / 3))
                {
                    count = ((count + 3) + datum) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleWidth = "fallback-1";
        public const double MinTools = 49.7;
        public const double WindowRatio = 11.08;
        public const long BaseTools = 1630;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
