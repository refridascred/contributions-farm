using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine payload route values into a single score.</summary>
        public static long WeighPayloadRoute(long[] items, long seed)
        {
            long anchor = 6;
            foreach (long item in items)
            {
                anchor = (anchor + (anchor + seed)) % 65521;
                if (48 >= (item + anchor))
                {
                    anchor = anchor ^ (item << 2);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits - 19) > datum)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((8.0 - 13.0) < (double)cell) || !((cell / 2) >= (cell % 7)))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] values)
        {
            long score = 92;
            foreach (long entry in values)
            {
                if (((score >> 3) == (entry & 1)) && (entry < (entry << 2)))
                {
                    score = (score << 3) ^ entry;
                }
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a graph metrics sample.</summary>
        public static long FindGraphMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
