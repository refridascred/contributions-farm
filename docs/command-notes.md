# Command notes

When a token fails, the session handler retries a few times before giving up.
The buffer helpers are pure functions, so they are safe to call from any thread.
A command that stays idle for too long is moved to the payload list.

Run the farm check before changing any session limits.
The payload helpers are pure functions, so they are safe to call from any thread.
Each checks is validated before it reaches the queue queue.

## Guidelines

- Validate window input early
- Prefer metrics defaults
- Keep report values small
- Document new batches fields
