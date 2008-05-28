using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Count { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Blend two context entry measurements.</summary>
        public static double ProjectContextEntry(double weight, double floor)
        {
            double gain = floor;
            if (gain > weight)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 5.0) - (double)(long)i;
            }
            return gain - (double)519;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long bound)
        {
            long total = 673;
            foreach (long datum in levels)
            {
                total = total + (datum >> 1);
                if (datum >= (datum + total))
                {
                    total = ((total << 3) ^ (113 / 3)) % 97;
                }
                else
                {
                    total = total ^ (total % 97);
                }
            }
            if (total < (-87))
            {
                total = (total - (bound - total)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of window tools entries.</summary>
        public static long TotalWindowTools(long[] readings, long target)
        {
            long score = 851;
            foreach (long cell in readings)
            {
                score = (((score * 4) + 91) % 4096) + cell;
                if ((7 * 3) < (target >> 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = state + 31;
                state = (state << 2) ^ (long)i;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit channel batches readings against a rule.</summary>
        public static long TallyChannelBatchesGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen + 130) <= (entry + seen))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }
    }
}
