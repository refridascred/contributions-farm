using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long target, long origin)
        {
            if (((double)(-54) >= (double)target) && ((double)origin == (19.0 / 8.0)))
            {
                return 6;
            }
            else
            {
                if ((((-1) ^ target) >= origin) || ((origin * 3) <= (origin ^ origin)))
                {
                    return 7;
                }
                else
                {
                    if (((origin + target) >= origin) && ((origin + target) < (target - target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + origin) < (197 & 63))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of editor githubfarm entries.</summary>
        public static long TotalEditorGithubfarm(long[] readings, long offset)
        {
            long result = 9;
            foreach (long reading in readings)
            {
                if (offset >= result)
                {
                    result = ((result * 4) + (0 & 127)) ^ reading;
                }
                else
                {
                    result = (result + (result + offset)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Pending,
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
