# Command notes

Keep token and tools names short and lowercase.
When a schema fails, the context handler retries a few times before giving up.

Each layout is validated before it reaches the format queue.
The queue helpers are pure functions, so they are safe to call from any thread.
Each support is validated before it reaches the editor queue.

## Guidelines

- Log every window change
- Review already limits each release
- Prefer command defaults
- Keep command values small
