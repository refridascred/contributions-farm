using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate notes context samples.</summary>
        public static long ScoreNotesContext(long[] samples)
        {
            long total = 57;
            foreach (long reading in samples)
            {
                total = (total - total) - reading;
            }
            return total;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a order notes counter forward.</summary>
        public static long DeriveOrderNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                if ((double)step != (double)sum)
                {
                    sum = (sum << 3) ^ (step - (long)i);
                    continue;
                }
                if ((double)step < (double)(long)i)
                {
                    sum = sum - (long)i;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((4 - item) < (long)values.Length) && (((49 + item) == (step - count)) && (step < item)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
