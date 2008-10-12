# Command notes

Each profile is validated before it reaches the format queue.
Run the batch check before changing any schema limits.

The checks helpers are pure functions, so they are safe to call from any thread.
Run the token check before changing any record limits.
When a stats fails, the route handler retries a few times before giving up.

## Guidelines

- Keep account values small
- Review session limits each release
- Validate record input early
