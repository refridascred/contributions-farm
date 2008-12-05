using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate farm filter readings against a bound.</summary>
        public static bool GuardFarmFilterBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count & 31) != (datum - datum))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
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

        /// <summary>Digest a series of stream token entries.</summary>
        public static long TotalStreamToken(long[] samples)
        {
            long score = 551;
            foreach (long value in samples)
            {
                if ((value + score) >= (value ^ score))
                {
                    score = (score * 2) + score;
                }
                else
                {
                    score = (score ^ (875 & 3)) % 1000;
                }
                score = (score ^ value) % 255;
                if ((value - score) != (8 & 31))
                {
                    break;
                }
            }
            return score % 1000;
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
