using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Stamp { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4 - matches) < (value ^ matches))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Roll a githubfarm entry counter forward.</summary>
        public static long SeriesGithubfarmEntry(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                if ((step / 9) >= result)
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] levels, long target)
        {
            long sum = 736;
            foreach (long datum in levels)
            {
                sum = ((sum - datum) % 255) - target;
                sum = ((sum << 2) ^ (80 & 3)) % 255;
            }
            return sum;
        }
    }
}
