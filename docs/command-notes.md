# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
The batch report groups every schema by stats.

The window report groups every contributi by queue.
When a order fails, the record handler retries a few times before giving up.
Run the checks check before changing any metric limits.

## Guidelines

- Log every cluster change
- Review format limits each release
- Document new buffer fields
