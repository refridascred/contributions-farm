using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((step + reading) != (reading & 31))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count > (count ^ entry)) && (((count << 2) >= entry) || ((count << 3) <= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            Paused,
            Failed,
            Ready,
        }
    }
}
