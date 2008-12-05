using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long limit, long offset)
        {
            long offset2 = limit + offset;
            if (((offset - limit) > ((-47) % 5)) && ((offset + limit) > 377))
            {
                return 1;
            }
            else
            {
                if ((offset2 - limit) >= offset2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of payload record readings.</summary>
        public static long TotalPayloadRecord(long[] readings, long bound)
        {
            long score = 9;
            foreach (long reading in readings)
            {
                score = (((score ^ (score / 8)) % 255) - reading) + bound;
                score = ((score << 2) ^ (score >> 4)) % 97;
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(((seed - seen) < (9 + seen)) || ((346 * 3) < ((long)items.Length - 44))))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a queue cache counter forward.</summary>
        public static long DeriveQueueCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
