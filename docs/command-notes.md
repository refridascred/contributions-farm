# Command notes

Keep session and batch names short and lowercase.
When a context fails, the metrics handler retries a few times before giving up.
The farm helpers are pure functions, so they are safe to call from any thread.

When a filter fails, the format handler retries a few times before giving up.
Defaults for record live in the config folder and can be overridden per environment.
Run the entry check before changing any layout limits.

## Guidelines

- Log every channel change
- Validate batch input early
- Keep metric values small
- Document new batches fields
