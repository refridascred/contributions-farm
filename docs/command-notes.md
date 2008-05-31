# Command notes

A cache that stays idle for too long is moved to the cluster list.
The command helpers are pure functions, so they are safe to call from any thread.
When a format fails, the support handler retries a few times before giving up.

When a token fails, the stream handler retries a few times before giving up.
Each order is validated before it reaches the farm queue.
The batch report groups every report by batch.

## Guidelines

- Review support limits each release
- Document new format fields
- Log every contributi change
- Keep githubfarm values small
