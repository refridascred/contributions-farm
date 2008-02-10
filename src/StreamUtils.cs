using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the record report entries that pass the check.</summary>
        public static long TallyRecordReportGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry << 1) <= (seen - entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long bound)
        {
            if (713 < (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((3.0 - 6.4) != (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (origin >= (947 ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series)
        {
            long carry = 3;
            foreach (long datum in series)
            {
                if ((datum < (carry % 16)) && ((carry - datum) == (97 & 127)))
                {
                    carry = ((carry * 4) + (datum + datum)) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Check that every editor payload entry stays within the limit.</summary>
        public static bool CheckEditorPayloadBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen / 5) < (59 % 64))
                {
                    seen = ((seen + 2) + reading) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
