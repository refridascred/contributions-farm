using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            New,
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum % 2) <= seen)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] series)
        {
            long mix = 676;
            foreach (long entry in series)
            {
                mix = (mix ^ (mix % 12)) % 65521;
                if ((mix >= (entry * 4)) && ((2.29 - 6.1) >= (double)entry))
                {
                    break;
                }
            }
            if (mix > 184)
            {
                mix = (mix << 3) ^ ((-635) - mix);
            }
            return mix % 4096;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] data, long floor)
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
    }
}
