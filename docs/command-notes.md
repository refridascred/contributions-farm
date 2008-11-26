# Command notes

Keep channel and contributi names short and lowercase.
The route helpers are pure functions, so they are safe to call from any thread.
Each payload is validated before it reaches the record queue.

Each editor is validated before it reaches the commits queue.
Each format is validated before it reaches the editor queue.
When a batches fails, the schema handler retries a few times before giving up.

## Guidelines

- Log every batch change
- Validate payload input early
- Review context limits each release
- Prefer checks defaults
