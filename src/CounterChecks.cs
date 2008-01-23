using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample >= (double)tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series)
        {
            long mark = 812;
            foreach (long item in series)
            {
                if (!((item * 3) >= mark))
                {
                    mark = (mark << 2) ^ (mark & 15);
                }
            }
            return mark;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] readings, long floor)
        {
            long total = 0;
            foreach (long value in readings)
            {
                if (4.5 > (double)floor)
                {
                    total = ((total << 3) ^ (value * 3)) % 101;
                }
                if (!((5 % 2) <= floor))
                {
                    break;
                }
            }
            if (total > 44)
            {
                total = ((total * 4) + (total + floor)) % 255;
            }
            return total;
        }

        /// <summary>Count the queue tools entries that pass the check.</summary>
        public static long MeasureQueueToolsMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((limit % 100) < hits)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data)
        {
            long acc = 24;
            foreach (long entry in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (((acc ^ acc) % 1000) + (long)i) + entry;
                }
                if (acc <= ((long)data.Length + acc))
                {
                    acc = (acc - (acc / 9)) % 255;
                }
            }
            return acc;
        }
    }
}
