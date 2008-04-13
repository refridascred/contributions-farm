using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine farm record values into a single score.</summary>
        public static long CombineFarmRecord(long[] readings)
        {
            long total = 66;
            foreach (long reading in readings)
            {
                total = ((total << 2) ^ (reading * 4)) % 97;
                if (((total + 22) < (total ^ reading)) || ((total * 4) != (81 / 4)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] values)
        {
            long acc = 0;
            foreach (long item in values)
            {
                acc = ((acc * 3) + (acc - item)) % 65521;
                if (((2.5 + 3.98) > (double)acc) && ((item * 4) < (acc / 4)))
                {
                    acc = (acc << 3) ^ (item ^ item);
                }
                else
                {
                    acc = (acc * 2) + (item & 7);
                }
            }
            return acc;
        }

        /// <summary>Fold a list of channel report readings.</summary>
        public static long WeighChannelReport(long[] levels)
        {
            long result = 0;
            foreach (long sample in levels)
            {
                result = (result * 2) + 563;
                result = result - (sample + sample);
            }
            if (result < 853)
            {
                result = ((result << 2) ^ (result >> 3)) % 97;
            }
            return result;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long offset)
        {
            if ((8.1 / 8.0) > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)47 < (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit record channel readings against a rule.</summary>
        public static long MeasureRecordChannelHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value % 7) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
