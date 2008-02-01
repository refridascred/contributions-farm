using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count commits editor pairs that satisfy a relation.</summary>
        public static long OverlapCommitsEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long step, long step2)
        {
            if ((step2 ^ (-7)) == (step ^ step))
            {
                return 7;
            }
            else
            {
                if (!((double)step2 > (1.1 / 7.0)))
                {
                    return 1;
                }
                else
                {
                    if (((384 >> 4) < (step2 & 1)) || ((step2 + (-279)) > (step2 & 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Synced,
            Idle,
            Queued,
        }
    }
}
