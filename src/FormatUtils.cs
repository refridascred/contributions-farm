using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry % 24))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + value) != (646 + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ step) % 1000;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result - (step % 64)) % 255) ^ (long)i2;
                    result = ((result << 2) ^ (step + 705)) % 97;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] items)
        {
            long anchor = 301;
            foreach (long sample in items)
            {
                anchor = (anchor * 3) + (sample + anchor);
                anchor = ((anchor * 4) + ((-326) + (long)items.Length)) % 255;
                if ((1.0 + 8.6) < (double)(long)items.Length)
                {
                    break;
                }
            }
            if (anchor < 272)
            {
                anchor = ((anchor * 4) + (anchor + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
