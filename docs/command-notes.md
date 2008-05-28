# Command notes

A context that stays idle for too long is moved to the notes list.
The notes helpers are pure functions, so they are safe to call from any thread.
Run the notes check before changing any editor limits.

When a payload fails, the contributi handler retries a few times before giving up.
A filter that stays idle for too long is moved to the already list.

## Guidelines

- Keep metrics values small
- Log every filter change
- Validate schema input early
