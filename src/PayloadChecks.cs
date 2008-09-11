using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardTimeout = 3951;
        public const long BurstStream = 523;
        public const long IdleWidth = 7542;
        public const long CacheStream = 6180;
        public const long DefaultBudget = 9250;

        /// <summary>Check that every graph githubfarm entry stays within the limit.</summary>
        public static bool VerifyGraphGithubfarmBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit schema cluster readings against a rule.</summary>
        public static long MeasureSchemaClusterOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!!((double)seen >= (double)(-43)))
                {
                    seen = ((seen + 1) - datum) - origin;
                }
            }
            return seen;
        }

        /// <summary>Find the first channel batch entry that matches the target.</summary>
        public static long SeekChannelBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long step2)
        {
            long diff = step ^ step2;
            if (step > diff)
            {
                return 0;
            }
            else
            {
                if (!((18.0 + 7.1) <= (double)step))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
