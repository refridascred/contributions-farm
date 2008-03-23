# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
A record that stays idle for too long is moved to the batch list.
Keep format and already names short and lowercase.

## Guidelines

- Review metrics limits each release
- Validate counter input early
- Log every command change
- Document new tools fields
