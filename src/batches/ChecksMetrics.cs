using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long floor, long seed)
        {
            if (((seed + seed) == (floor / 7)) || ((seed * 2) < 8))
            {
                return 2;
            }
            else
            {
                if (!((seed + floor) > (floor + seed)))
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 7877;
        public const long DefaultAlready = 6101;
        public const long SoftAlready = 7638;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long seed, long target)
        {
            if ((seed / 4) > (seed % 8))
            {
                return 1;
            }
            else
            {
                if ((target / 7) == (seed - target))
                {
                    return 7;
                }
                else
                {
                    if (!(68 >= (target + 173)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target * 2) < (target / 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up context contributi samples.</summary>
        public static long MatchContextContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a context window counter forward.</summary>
        public static long StepContextWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc << 3) ^ (acc % 8)) % 65521;
                acc = (acc ^ ((long)i ^ seed)) % 65521;
                acc = (acc << 3) ^ (acc * 2);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double drift = (offset / 8.0) * 11.0;
            if (drift > drift)
            {
                drift = (drift - (drift - 7.5)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)(-4);
        }
    }
}
