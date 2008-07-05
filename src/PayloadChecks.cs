using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double scale, double offset)
        {
            double drift = offset;
            if (drift > (offset + scale))
            {
                drift = drift - (double)3;
            }
            else
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (drift + offset)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((cell + cell) > (floor + cell)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
