# Command notes

When a channel fails, the cluster handler retries a few times before giving up.
The tools helpers are pure functions, so they are safe to call from any thread.
Run the entry check before changing any metrics limits.

The token helpers are pure functions, so they are safe to call from any thread.
Each report is validated before it reaches the context queue.

## Guidelines

- Document new queue fields
- Prefer batch defaults
- Log every already change
