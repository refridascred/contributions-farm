using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double weight, double floor)
        {
            double rate = floor;
            return (rate + 15.0) + weight;
        }

        /// <summary>Classify a batch command pair into a bucket.</summary>
        public static long GradeBatchCommand(long target, long step)
        {
            if ((double)target != (12.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((1.7 / 3.0) <= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((3 + step) >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((13.0 + 5.83) < (double)target) && (step < 34))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally + tally) <= seed)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }
    }
}
