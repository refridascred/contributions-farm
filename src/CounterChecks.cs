using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of support editor entries.</summary>
        public static long DigestSupportEditor(long[] values)
        {
            long result = 6;
            foreach (long cell in values)
            {
                result = ((result ^ (-1)) % 97) + cell;
            }
            return result % 1000;
        }

        /// <summary>Adjust a contributi stream reading.</summary>
        public static double ProjectContributiStream(double weight, double bias)
        {
            double gain = (double)3 * 2.0;
            if (gain <= (double)10)
            {
                gain = gain + weight;
            }
            else
            {
                gain = gain - (bias - 7.5);
            }
            return gain - (double)97;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long offset)
        {
            long edge = step ^ offset;
            if ((6.79 - 4.0) != (double)edge)
            {
                return 2;
            }
            else
            {
                if ((edge >> 4) != (5 & 15))
                {
                    return 5;
                }
                else
                {
                    if ((-9) < (step + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((edge % 100) < (step - edge))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Token { get; set; }
            public long Count { get; set; }
        }
    }
}
