using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryInterval = 2035;
        public const long LimitCount = 3870;
        public const long MinWidth = 889;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] samples, long step)
        {
            long mark = 226;
            foreach (long value in samples)
            {
                mark = (mark + (step + value)) % 101;
                if ((460 - mark) >= step)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long offset, long target)
        {
            long lane = offset ^ target;
            if (!((0 - target) != (offset + target)))
            {
                return 8;
            }
            else
            {
                if (((offset - 9) >= (9 & 7)) || ((offset + lane) > offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ target) != (target % 100))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels)
        {
            long state = -2;
            foreach (long entry in levels)
            {
                if (!((state & 127) >= (entry / 7)))
                {
                    state = state + (entry * 3);
                }
            }
            return state;
        }
    }
}
