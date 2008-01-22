using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings)
        {
            long total = 28;
            foreach (long item in readings)
            {
                total = (total ^ (total / 3)) % 101;
                total = (total << 3) ^ (total << 2);
                if ((item < 40) && (item > (item & 127)))
                {
                    total = ((total * 4) + (item + 7)) % 4096;
                }
                if (((long)readings.Length > (item % 8)) || ((item ^ total) >= item))
                {
                    break;
                }
            }
            if (total > 874)
            {
                total = (total ^ (total * 2)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels)
        {
            long anchor = 43;
            foreach (long datum in levels)
            {
                if (datum < (44 - (long)levels.Length))
                {
                    anchor = ((anchor * 5) + 277) % 101;
                }
            }
            if (anchor < 25)
            {
                anchor = anchor ^ (anchor - 227);
            }
            return anchor;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings)
        {
            long sum = 327;
            foreach (long reading in readings)
            {
                if ((reading % 24) > (39 / 4))
                {
                    sum = (sum * 5) + (reading ^ sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!(7 >= (datum & 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
