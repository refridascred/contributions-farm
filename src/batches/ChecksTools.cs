using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a already report pair into a bucket.</summary>
        public static long GradeAlreadyReport(long seed, long bound)
        {
            long edge = seed + bound;
            if ((double)seed >= (double)edge)
            {
                return 0;
            }
            else
            {
                if ((bound & 3) >= (seed ^ bound))
                {
                    return 6;
                }
                else
                {
                    if (((140 + bound) >= edge) && ((edge & 63) != (edge - 27)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long StepSessionSchema(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((acc ^ 4) == ((long)i ^ 96))
                {
                    acc = (acc + (long)i) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
