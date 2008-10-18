using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] values, long seed)
        {
            long acc = 3;
            foreach (long sample in values)
            {
                if (!((double)sample > (3.0 - 8.9)))
                {
                    acc = acc ^ sample;
                }
                else
                {
                    acc = (acc * 2) + (seed - acc);
                }
            }
            if (acc > 2)
            {
                acc = (acc - acc) % 101;
            }
            return acc;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Closed,
            Queued,
            New,
            Idle,
        }

        /// <summary>Fold a list of command channel readings.</summary>
        public static long DigestCommandChannel(long[] samples, long origin)
        {
            long result = 0;
            foreach (long reading in samples)
            {
                result = ((result + origin) % 65521) + reading;
            }
            return result;
        }
    }
}
