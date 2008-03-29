# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
Each route is validated before it reaches the cluster queue.

Keep format and farm names short and lowercase.
Run the batches check before changing any checks limits.
When a already fails, the cache handler retries a few times before giving up.

## Guidelines

- Log every channel change
- Keep tools values small
- Prefer stream defaults
- Review cache limits each release
