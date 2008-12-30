using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long limit)
        {
            long offset2 = offset - limit;
            if ((limit - limit) >= 803)
            {
                return 8;
            }
            else
            {
                if (!(limit < (limit << 3)))
                {
                    return 1;
                }
                else
                {
                    if ((offset < (685 >> 3)) && (offset < (limit ^ offset2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + limit) != (limit & 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Idle,
            Paused,
            Failed,
            Queued,
        }
    }
}
