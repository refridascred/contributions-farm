# Command notes

Use schema settings to tune how often batches data is refreshed.
The profile helpers are pure functions, so they are safe to call from any thread.
A entry that stays idle for too long is moved to the cache list.

## Guidelines

- Review contributi limits each release
- Keep entry values small
- Log every counter change
- Document new account fields
