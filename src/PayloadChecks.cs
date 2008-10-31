using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double gain, double offset)
        {
            double scale = 5.3;
            if (scale <= (10.0 / 8.0))
            {
                scale = ((scale - 0.03) - gain) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale * 5.0)) + (double)(long)i;
            }
            return scale + (double)2;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] samples)
        {
            long score = 0;
            foreach (long sample in samples)
            {
                score = ((score - score) % 65521) ^ sample;
            }
            return score % 4096;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long floor, long step)
        {
            long offset = floor + step;
            if ((offset >> 1) >= (offset / 5))
            {
                return 6;
            }
            else
            {
                if ((offset & 63) <= step)
                {
                    return 2;
                }
                else
                {
                    if (floor >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor < (offset ^ step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stream payload samples.</summary>
        public static long DigestStreamPayload(long[] items, long seed)
        {
            long mix = 648;
            foreach (long reading in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (((mix * 2) + reading) % 1000) ^ (long)i;
                }
                if ((437 ^ mix) == (mix + 719))
                {
                    mix = (mix + (34 + seed)) % 1000;
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }
    }
}
