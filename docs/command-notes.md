# Command notes

Run the batch check before changing any record limits.
Each githubfarm is validated before it reaches the report queue.
The cluster helpers are pure functions, so they are safe to call from any thread.

When a batches fails, the farm handler retries a few times before giving up.
Run the batch check before changing any checks limits.

## Guidelines

- Validate support input early
- Keep token values small
- Review format limits each release
