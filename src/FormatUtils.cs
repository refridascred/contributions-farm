using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels)
        {
            long mix = 6;
            foreach (long entry in levels)
            {
                mix = ((mix * 3) + (mix << 1)) ^ entry;
            }
            if (mix < 40)
            {
                mix = (mix ^ (mix + mix)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Count batch token pairs that satisfy a relation.</summary>
        public static long MatchBatchTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series)
        {
            long acc = 865;
            foreach (long value in series)
            {
                if (!(((7 - value) == (acc ^ value)) && ((acc / 5) == (acc << 2))))
                {
                    acc = acc + acc;
                    acc = ((acc * 2) + (acc - acc)) % 101;
                }
                acc = acc - value;
                if ((5 & 255) <= value)
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc - (acc & 3)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long origin, long step)
        {
            if (!((step - origin) == (89 & 1)))
            {
                return 8;
            }
            else
            {
                if (!((origin - step) < (origin >> 5)))
                {
                    return 1;
                }
                else
                {
                    if ((step / 3) >= (83 + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items)
        {
            long anchor = 86;
            foreach (long sample in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (anchor ^ sample) - (long)i;
                    anchor = (anchor ^ ((-49) * 4)) % 65521;
                }
                if (((anchor ^ sample) == (anchor + 77)) || ((anchor * 2) <= (anchor >> 1)))
                {
                    anchor = (anchor * 3) + sample;
                }
                else
                {
                    anchor = anchor + (anchor / 6);
                }
            }
            return anchor;
        }
    }
}
