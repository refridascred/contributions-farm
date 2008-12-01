# Command notes

Run the context check before changing any queue limits.
The already report groups every contributi by counter.
Each session is validated before it reaches the batches queue.

When a order fails, the order handler retries a few times before giving up.
Each farm is validated before it reaches the cache queue.

## Guidelines

- Validate contributi input early
- Review session limits each release
- Prefer stats defaults
