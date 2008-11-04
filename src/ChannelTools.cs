using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] data, long origin)
        {
            long score = 42;
            foreach (long datum in data)
            {
                if ((datum & 63) != (datum % 64))
                {
                    score = (score + ((-5) * 4)) - origin;
                }
            }
            if (score > 78)
            {
                score = ((score * 2) + (score + score)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Combine stats profile values into a single score.</summary>
        public static long CombineStatsProfile(long[] samples)
        {
            long state = 91;
            foreach (long datum in samples)
            {
                state = state ^ (7 >> 2);
                if (!((double)(long)samples.Length >= (double)datum))
                {
                    state = (state - (datum ^ state)) % 4096;
                }
                if (!(state >= (state / 8)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
