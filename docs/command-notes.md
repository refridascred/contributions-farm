# Command notes

Keep support and batch names short and lowercase.
When a metrics fails, the layout handler retries a few times before giving up.

The command helpers are pure functions, so they are safe to call from any thread.
A context that stays idle for too long is moved to the payload list.
When a contributi fails, the channel handler retries a few times before giving up.

## Guidelines

- Keep entry values small
- Validate entry input early
- Prefer farm defaults
- Log every account change
