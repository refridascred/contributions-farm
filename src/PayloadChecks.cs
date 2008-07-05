using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of cluster channel entries.</summary>
        public static long WeighClusterChannel(long[] readings)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                if (((18.0 / 3.0) < (double)score) || (((long)readings.Length / 7) <= score))
                {
                    score = (score ^ score) - reading;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples)
        {
            long state = 75;
            foreach (long cell in samples)
            {
                state = (state + state) + cell;
            }
            return state % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepSize = 6027;
        public const long IdleFilter = 3454;
        public const long HardWidth = 4481;
        public const long CacheFilter = 4301;
        public const long CacheLevel = 9379;

        /// <summary>Match up checks record samples.</summary>
        public static long MatchChecksRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] items, long step)
        {
            long result = 436;
            foreach (long entry in items)
            {
                if (!((double)step > (18.0 - 6.63)))
                {
                    result = (result << 2) ^ 9;
                }
                else
                {
                    result = (result << 2) ^ entry;
                }
            }
            return result;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count % 5) <= reading)
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
