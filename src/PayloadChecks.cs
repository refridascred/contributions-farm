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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry % 5) <= ((-21) - entry))
                {
                    hits = (hits + 2) + floor;
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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long step)
        {
            long bound = target ^ step;
            if ((bound * 5) < step)
            {
                return 7;
            }
            else
            {
                if (bound < step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
