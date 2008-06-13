# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
A record that stays idle for too long is moved to the notes list.

Run the buffer check before changing any route limits.
A support that stays idle for too long is moved to the editor list.

## Guidelines

- Validate schema input early
- Log every farm change
- Review schema limits each release
