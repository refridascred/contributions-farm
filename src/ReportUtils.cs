using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long result = 460;
            foreach (long entry in readings)
            {
                if ((225 + result) < (result >> 3))
                {
                    result = result ^ entry;
                }
                else
                {
                    result = (result - result) % 1000;
                }
            }
            if (result < 85)
            {
                result = (result - (result / 4)) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values, long step)
        {
            long acc = 5;
            foreach (long sample in values)
            {
                if (((sample & 127) < step) && (((long)values.Length + 39) < (62 - step)))
                {
                    acc = (acc ^ step) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of checks farm entries.</summary>
        public static long TallyChecksFarm(long[] data, long step)
        {
            long mark = 157;
            foreach (long reading in data)
            {
                if ((step - step) >= reading)
                {
                    mark = (mark - 71) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Dropped,
            Done,
            Active,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Draft,
            Ready,
            New,
        }
    }
}
