using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((double)offset < (double)(long)i)
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values, long step)
        {
            long score = 52;
            foreach (long value in values)
            {
                score = ((score ^ step) % 4096) + value;
            }
            if (score > (-6))
            {
                score = (score << 3) ^ (score + step);
            }
            return score % 4096;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Queued,
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((((matches >> 3) < 400) || ((3.0 / 3.0) > (double)step)) && ((step >= 197) || ((5 * 3) == (reading - reading))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
