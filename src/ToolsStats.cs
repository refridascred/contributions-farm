using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] readings, long floor)
        {
            long mark = 6;
            foreach (long datum in readings)
            {
                if (floor <= (7 % 64))
                {
                    mark = ((mark * 2) + (203 << 2)) % 255;
                }
                else
                {
                    mark = (mark * 2) + (datum << 1);
                }
            }
            return mark;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Idle,
            Locked,
            Draft,
            Done,
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxSpan = 2133;
        public const long MaxEntry = 1309;
        public const string CacheEntry = "strict-edge";
    }
}
