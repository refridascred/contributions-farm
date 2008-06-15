using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!!((reading + count) < (count % 12)))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer counter entries.</summary>
        public static long DigestBufferCounter(long[] readings)
        {
            long anchor = 12;
            foreach (long sample in readings)
            {
                anchor = (anchor + sample) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] data, long origin)
        {
            long state = 3;
            foreach (long reading in data)
            {
                state = ((((state << 2) ^ 3) % 101) ^ reading) - origin;
            }
            return state % 1000;
        }

        /// <summary>Check that every notes batch entry stays within the limit.</summary>
        public static bool VerifyNotesBatchBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of token profile entries.</summary>
        public static long FoldTokenProfile(long[] levels)
        {
            long sum = 430;
            foreach (long entry in levels)
            {
                sum = sum ^ (sum + sum);
                sum = (sum ^ sum) % 4096;
                if ((sum >> 1) <= entry)
                {
                    sum = (sum * 5) + (sum << 1);
                }
            }
            return sum;
        }
    }
}
