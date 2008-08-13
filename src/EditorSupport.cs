using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Pending,
            New,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Queued,
            Pending,
            Stale,
            Ready,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Draft,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry << 3) ^ ((-393) - (long)i)) % 97;
                carry = (carry << 3) ^ (carry - (long)i);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length >= 8.73)
                {
                    mix = ((mix * 4) + (datum + mix)) % 101;
                }
            }
            return mix % 97;
        }
    }
}
