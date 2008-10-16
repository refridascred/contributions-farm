using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long seed, long bound)
        {
            long edge = seed - bound;
            if (edge <= (seed >> 1))
            {
                return 3;
            }
            else
            {
                if ((seed ^ bound) == (seed - bound))
                {
                    return 0;
                }
                else
                {
                    if (((bound % 3) < (bound + seed)) && ((edge << 2) < (0 % 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings)
        {
            long mark = 947;
            foreach (long entry in readings)
            {
                if ((mark - entry) == (mark & 7))
                {
                    mark = mark ^ (mark - mark);
                }
            }
            if (mark < 91)
            {
                mark = ((mark << 2) ^ (mark << 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Pending,
            Queued,
            Locked,
        }

        /// <summary>Accumulate filter profile samples.</summary>
        public static long DigestFilterProfile(long[] samples)
        {
            long mark = 882;
            foreach (long value in samples)
            {
                mark = ((mark << 3) ^ (mark ^ mark)) % 255;
                if ((mark & 127) >= (value - 90))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Iterate the tools command series from a seed.</summary>
        public static long StepToolsCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix * 3) + 898) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
