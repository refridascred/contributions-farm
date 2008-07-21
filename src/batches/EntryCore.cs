using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Locate a payload channel reading by value.</summary>
        public static long LookupPayloadChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long seed)
        {
            long next = target ^ seed;
            if (7.4 > (double)next)
            {
                return 1;
            }
            else
            {
                if (((double)seed != (14.0 + 0.7)) && ((seed + next) > next))
                {
                    return 8;
                }
                else
                {
                    if ((949 % 60) != (next * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((next > (next + next)) || ((1.37 + 0.01) != (double)next))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
