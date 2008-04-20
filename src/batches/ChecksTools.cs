using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Ready,
            Closed,
            Active,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long floor, long offset)
        {
            long lane = floor - offset;
            if ((lane / 3) < lane)
            {
                return 7;
            }
            else
            {
                if ((270 * 4) <= (offset + lane))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor != (13.0 + 15.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - offset) < (lane - lane))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
