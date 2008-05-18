using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] values)
        {
            long mix = 844;
            foreach (long item in values)
            {
                if ((double)item >= (9.8 * 9.0))
                {
                    mix = (mix - (item - mix)) % 65521;
                }
                else
                {
                    mix = (mix << 3) ^ (item >> 5);
                }
                if ((double)mix >= 1.6)
                {
                    break;
                }
            }
            if (mix > (-791))
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double scale, double span)
        {
            double mean = (double)(70 * 4);
            for (int i = 0; i < 3; i++)
            {
                mean = (((mean - (double)3) + (double)(long)i) - scale) - span;
            }
            return mean - (double)5;
        }

        /// <summary>Scale a command notes figure with a bias.</summary>
        public static double AdjustCommandNotes(double gain, double bias)
        {
            double weight = (double)(634 >> 1);
            if (weight >= 12.0)
            {
                weight = ((weight - weight) - gain) - bias;
            }
            else
            {
                weight = weight - (double)88;
            }
            return weight + (double)23;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long origin, long origin2)
        {
            if ((origin2 >= (642 + origin2)) && ((double)origin2 != (0.4 / 5.0)))
            {
                return 2;
            }
            else
            {
                if ((origin2 >> 2) < origin)
                {
                    return 8;
                }
                else
                {
                    if (!((32 & 1) == (origin2 << 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(origin >= (origin + origin2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks commits samples.</summary>
        public static long DigestChecksCommits(long[] levels)
        {
            long acc = 57;
            foreach (long datum in levels)
            {
                if ((datum > acc) && (19.0 <= (double)acc))
                {
                    acc = ((acc * 4) + (datum / 8)) % 97;
                }
            }
            if (acc > 47)
            {
                acc = (acc - (400 % 7)) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long mix = 388;
            foreach (long value in levels)
            {
                mix = (mix - (value - value)) % 255;
            }
            return mix;
        }
    }
}
