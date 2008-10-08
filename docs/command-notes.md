# Command notes

The notes report groups every cluster by batches.
Run the token check before changing any metric limits.
When a schema fails, the record handler retries a few times before giving up.

The editor helpers are pure functions, so they are safe to call from any thread.
A layout that stays idle for too long is moved to the batches list.

## Guidelines

- Log every cache change
- Document new session fields
- Keep tools values small
