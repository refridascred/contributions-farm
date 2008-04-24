# Command notes

When a session fails, the already handler retries a few times before giving up.
Run the queue check before changing any window limits.

The farm helpers are pure functions, so they are safe to call from any thread.
When a record fails, the window handler retries a few times before giving up.

## Guidelines

- Log every record change
- Document new tools fields
- Validate metric input early
