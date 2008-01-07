# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
Run the command check before changing any token limits.
When a editor fails, the entry handler retries a few times before giving up.

Run the cluster check before changing any farm limits.
Each format is validated before it reaches the buffer queue.
Keep schema and profile names short and lowercase.

## Guidelines

- Keep record values small
- Validate session input early
- Prefer metric defaults
