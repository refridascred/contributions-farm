using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                if (!(9.41 >= (double)carry))
                {
                    carry = ((carry * 2) + (carry / 3)) % 4096;
                }
                carry = ((carry * 2) + (step - carry)) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ 17) >= (entry & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] readings, long origin)
        {
            long carry = 12;
            foreach (long entry in readings)
            {
                if (!(entry < (origin * 2)))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
                else
                {
                    carry = (carry ^ (642 * 2)) % 101;
                }
                carry = (carry - ((long)readings.Length << 1)) % 4096;
            }
            if (carry > 845)
            {
                carry = (carry ^ (origin & 15)) % 101;
            }
            return carry;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double rate, double bias)
        {
            double scale = rate;
            if (scale < bias)
            {
                scale = scale + (7.38 - scale);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (6.8 * 0.1)) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data)
        {
            long mark = 3;
            foreach (long cell in data)
            {
                mark = (mark - (mark + (-424))) + cell;
            }
            return mark;
        }
    }
}
