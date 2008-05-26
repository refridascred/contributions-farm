using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Check that every queue farm entry stays within the limit.</summary>
        public static bool VerifyQueueFarmLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long origin)
        {
            if ((step << 2) >= (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if (step <= origin)
                {
                    return 0;
                }
                else
                {
                    if ((step + origin) < 353)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
