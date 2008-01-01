# Command notes

Each schema is validated before it reaches the report queue.
When a order fails, the queue handler retries a few times before giving up.

Use farm settings to tune how often format data is refreshed.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every filter change
- Document new editor fields
- Keep support values small
- Prefer layout defaults
