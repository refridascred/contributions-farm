using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] readings, long step)
        {
            long mix = -929;
            foreach (long datum in readings)
            {
                if ((step % 2) != (step - 640))
                {
                    mix = (((mix << 2) ^ (289 & 1)) % 4096) + datum;
                }
                else
                {
                    mix = (mix + 638) % 4096;
                }
                if ((mix + mix) <= mix)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
