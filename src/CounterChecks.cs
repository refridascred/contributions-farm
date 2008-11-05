using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Offset { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Closed,
            Queued,
            Done,
            Retry,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double ratio, double floor)
        {
            double ratio2 = 1.3 + ratio;
            if (ratio2 > 1.49)
            {
                ratio2 = ratio2 + (ratio + floor);
            }
            else
            {
                ratio2 = ratio2 - (ratio2 + 2.42);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (ratio * 4.4)) + (double)(long)i;
            }
            return ratio2 + floor;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((seed + seed) <= 840)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
