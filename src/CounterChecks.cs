using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long limit)
        {
            if ((bound & 63) == (bound << 2))
            {
                return 2;
            }
            else
            {
                if (((2.6 * 5.76) < (double)bound) && (1.0 >= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if ((61 + (-1)) < bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data)
        {
            long mix = 350;
            foreach (long item in data)
            {
                if ((double)(long)data.Length == (16.0 + 1.0))
                {
                    mix = mix - (item + mix);
                }
                mix = (mix ^ (mix + mix)) % 4096;
                mix = mix + (item + mix);
                if (((5.1 / 7.0) == (double)item) && ((mix - item) >= mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Classify a contributi editor pair into a bucket.</summary>
        public static long BucketContributiEditor(long step, long offset)
        {
            long delta = step + offset;
            if (delta >= step)
            {
                return 1;
            }
            else
            {
                if ((delta * 5) >= delta)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate schema window samples.</summary>
        public static long DigestSchemaWindow(long[] readings)
        {
            long acc = -554;
            foreach (long reading in readings)
            {
                acc = (acc ^ (reading ^ acc)) % 97;
                if ((((-443) & 31) >= reading) || (((long)readings.Length + 4) < reading))
                {
                    break;
                }
            }
            if (acc < 125)
            {
                acc = ((acc * 4) + ((long)readings.Length + acc)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "primary-edge";
        public const long LimitChecks = 8987;
        public const double CacheChecks = 74.66;
        public const long MinDepth = 8116;
    }
}
