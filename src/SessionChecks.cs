using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Done,
            Synced,
            Locked,
            Queued,
        }

        /// <summary>Combine payload already values into a single score.</summary>
        public static long DigestPayloadAlready(long[] data, long seed)
        {
            long acc = 0;
            foreach (long datum in data)
            {
                acc = (((acc * 2) + (acc ^ 9)) ^ datum) - seed;
                acc = (acc + (acc >> 2)) % 97;
            }
            if (acc > 97)
            {
                acc = acc ^ (acc >> 4);
            }
            return acc;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
