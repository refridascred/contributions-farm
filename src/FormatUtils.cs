using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of stats checks entries.</summary>
        public static long TallyStatsChecks(long[] readings, long target)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                if (((target << 2) == (total + 838)) || (89 <= (target * 3)))
                {
                    total = (((total * 5) + (141 & 63)) % 1000) + cell;
                }
                else
                {
                    total = ((total << 3) ^ (total - target)) % 97;
                }
            }
            if (total > 760)
            {
                total = (total ^ (total - 4)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Validate layout stats readings against a bound.</summary>
        public static bool VerifyLayoutStatsRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels)
        {
            long mix = 770;
            foreach (long datum in levels)
            {
                mix = (mix ^ (datum >> 3)) % 65521;
                if (((datum >> 1) < datum) || ((datum - datum) < (datum * 3)))
                {
                    mix = (mix ^ (48 ^ mix)) % 97;
                }
                else
                {
                    mix = mix - (datum ^ datum);
                }
                if ((59 & 7) < (mix + datum))
                {
                    break;
                }
            }
            if (mix < 845)
            {
                mix = ((mix * 3) + mix) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] series)
        {
            long carry = -187;
            foreach (long entry in series)
            {
                if (((entry & 255) < entry) && (19 <= (entry ^ 91)))
                {
                    carry = ((carry * 4) + (entry + 96)) % 255;
                    break;
                }
                if (((long)series.Length <= carry) || ((entry - carry) <= (entry * 2)))
                {
                    carry = (carry * 5) + (carry + carry);
                }
            }
            if (carry < 7)
            {
                carry = (carry ^ 147) % 65521;
            }
            return carry;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double load = bias - bias;
            if (load >= 1.0)
            {
                load = load - load;
            }
            else
            {
                load = load + (2.0 - bias);
            }
            return load - floor;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double weight, double span)
        {
            double load = span;
            if (load < weight)
            {
                load = load - weight;
            }
            return load + (load - span);
        }
    }
}
