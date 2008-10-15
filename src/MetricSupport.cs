using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a editor buffer pair into a bucket.</summary>
        public static long GradeEditorBuffer(long floor, long limit)
        {
            if (((double)floor <= (3.5 + 9.0)) && ((double)floor == (3.44 + 3.09)))
            {
                return 6;
            }
            else
            {
                if (20.0 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((floor >> 4) < (147 * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit != (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stats checks values into a single score.</summary>
        public static long FoldStatsChecks(long[] samples)
        {
            long carry = 6;
            foreach (long item in samples)
            {
                if ((0.54 - 13.0) <= (double)carry)
                {
                    carry = carry + (item & 7);
                }
                if (((double)carry > (double)item) || ((double)carry < (double)item))
                {
                    break;
                }
            }
            if (carry > 9)
            {
                carry = (carry + (55 + carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!((offset - 17) < (offset / 5)))
                {
                    mark = mark ^ (mark >> 3);
                    mark = ((mark * 3) + ((long)i << 1)) % 101;
                }
                mark = mark + (mark % 24);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
