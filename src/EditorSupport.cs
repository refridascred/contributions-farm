using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Done,
            Queued,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (result ^ offset) ^ (long)i2;
                }
                result = (result ^ result) % 101;
                result = (result ^ (offset >> 3)) % 65521;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long FoldClusterCounter(long[] values, long origin)
        {
            long sum = -832;
            foreach (long datum in values)
            {
                if ((datum % 5) > (sum + 37))
                {
                    sum = (sum - (3 + origin)) % 1000;
                }
                sum = (sum - 2) % 65521;
                if ((datum ^ origin) == (sum ^ sum))
                {
                    sum = (sum + (sum % 16)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowLevel = "stable-edge";
        public const long BaseNotes = 8100;
        public const double MaxNotes = 66.49;
        public const long IdleFactor = 8577;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
