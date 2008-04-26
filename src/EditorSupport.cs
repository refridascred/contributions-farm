using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long limit, long target)
        {
            if ((target ^ target) <= (806 << 1))
            {
                return 2;
            }
            else
            {
                if ((target + limit) < (target << 3))
                {
                    return 5;
                }
                else
                {
                    if (14.0 < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target * 3) != (7 * 4)) || ((limit + 68) != (target * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] samples, long step)
        {
            long mark = 9;
            foreach (long entry in samples)
            {
                mark = ((mark ^ mark) % 97) - step;
                mark = ((mark << 2) ^ (entry << 2)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = (((result << 2) ^ (result ^ result)) % 4096) ^ cell;
            }
            return result % 4096;
        }
    }
}
