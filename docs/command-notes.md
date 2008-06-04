# Command notes

Keep format and context names short and lowercase.
Run the format check before changing any layout limits.
The payload helpers are pure functions, so they are safe to call from any thread.

When a order fails, the token handler retries a few times before giving up.
Each order is validated before it reaches the counter queue.

## Guidelines

- Prefer batches defaults
- Validate record input early
- Keep cache values small
- Document new graph fields
