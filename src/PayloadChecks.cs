using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long origin)
        {
            long carry = -81;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (carry << 3) ^ ((long)i + origin);
                }
                carry = carry + (carry - carry);
                if ((499 << 3) >= origin)
                {
                    carry = (carry * 5) + (entry + 2);
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series, long step)
        {
            long score = 543;
            foreach (long item in series)
            {
                score = (((score << 2) ^ (score ^ score)) % 97) ^ item;
            }
            if (score > 50)
            {
                score = ((score * 3) + (step - score)) % 97;
            }
            return score;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((limit >= datum) && ((double)datum >= (13.0 - 19.0))) || (datum <= (limit % 10)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowSize = 4261;
        public const long BaseSpan = 5946;
        public const long BurstCommits = 8553;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
