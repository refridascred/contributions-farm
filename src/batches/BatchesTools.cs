using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long bound, long floor)
        {
            if (((bound & 63) < floor) && ((floor / 5) == (2 + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)floor <= (12.0 + 13.0))
                {
                    return 8;
                }
                else
                {
                    if (!((floor % 60) < 12))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (15.0 + 19.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Failed,
            Active,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double weight = (8.6 - span) + (bias + span);
            return weight + weight;
        }
    }
}
