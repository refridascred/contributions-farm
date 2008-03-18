using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Label { get; set; }
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count session filter pairs that satisfy a relation.</summary>
        public static long OverlapSessionFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 5191;
        public const string MaxGraph = "alpha";
        public const long WindowTimeout = 3022;
        public const long RetryGraph = 8016;
        public const long RetryInterval = 1370;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                sum = (sum * 4) + ((long)levels.Length & 15);
                if (((reading * 4) > (reading + (long)levels.Length)) && ((sum + sum) >= (sum ^ (long)levels.Length)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = sum ^ (limit * 5);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
