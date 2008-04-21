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

        /// <summary>Measure how many buffer stream samples are out of range.</summary>
        public static long TallyBufferStreamGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading % 97) >= (reading - tally))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double rate = weight;
            return rate + (offset * 8.98);
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
