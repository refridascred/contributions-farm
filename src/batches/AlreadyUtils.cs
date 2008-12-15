using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (bound >= (matches % 16))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items)
        {
            long carry = 418;
            foreach (long item in items)
            {
                if ((item + item) <= carry)
                {
                    carry = (carry - item) % 1000;
                }
            }
            if (carry < 97)
            {
                carry = ((carry << 2) ^ (76 + carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Count stream metrics pairs that satisfy a relation.</summary>
        public static long PairStreamMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
