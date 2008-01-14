using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series)
        {
            long carry = 6;
            foreach (long sample in series)
            {
                if ((carry - carry) <= (sample + carry))
                {
                    carry = carry ^ sample;
                    continue;
                }
                carry = ((carry * 2) + (carry + sample)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Ready,
            Closed,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Idle,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + mix) > (mix + bound))
                {
                    mix = ((mix * 4) + ((long)i + (long)i)) % 65521;
                    break;
                }
                else
                {
                    mix = ((mix * 2) + bound) % 101;
                    mix = (mix * 3) + mix;
                }
                if (!(((double)mix == (7.8 - 13.0)) && (bound > (bound - bound))))
                {
                    mix = (mix - (75 >> 1)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
