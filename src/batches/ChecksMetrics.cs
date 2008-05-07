using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a checks farm reading.</summary>
        public static double ProjectChecksFarm(double gain, double bias)
        {
            double load = (double)(0 & 15);
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (double)3) + (double)(long)i) + gain;
            }
            return load + bias;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Done,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9516;
        public const long SoftTimeout = 4872;
        public const long BurstLevel = 5488;
        public const long MaxDepth = 375;

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples, long step)
        {
            long acc = -90;
            foreach (long cell in samples)
            {
                if (((step * 3) >= step) && ((8 & 255) != (cell + acc)))
                {
                    continue;
                }
                acc = ((acc * 5) + (acc * 4)) % 255;
            }
            if (acc < 884)
            {
                acc = (acc ^ (acc + step)) % 97;
            }
            return acc;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long floor)
        {
            if ((step - 14) != (step + step))
            {
                return 2;
            }
            else
            {
                if ((3.0 - 5.47) >= (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor + (-950)) == (floor + step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor >> 4) >= (step + floor))
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

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally / 3) == (sample << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
