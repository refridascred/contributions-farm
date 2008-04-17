# Command notes

When a token fails, the metrics handler retries a few times before giving up.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
Each farm is validated before it reaches the graph queue.

Run the format check before changing any report limits.
Run the notes check before changing any checks limits.

## Guidelines

- Prefer channel defaults
- Keep channel values small
- Review farm limits each release
