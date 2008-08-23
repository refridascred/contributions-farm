using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + cell) != (9 - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((20 - cell) < (tally << 2)) && ((tally & 127) > (tally >> 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long step)
        {
            long gap = limit - step;
            if ((limit > (gap >> 1)) || ((limit << 3) <= 8))
            {
                return 0;
            }
            else
            {
                if (step > (gap ^ limit))
                {
                    return 3;
                }
                else
                {
                    if ((49 & 255) < (gap & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step << 3) <= limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] data)
        {
            long score = 96;
            foreach (long value in data)
            {
                if ((value + score) > (score << 1))
                {
                    score = score ^ score;
                }
            }
            return score % 65521;
        }
    }
}
