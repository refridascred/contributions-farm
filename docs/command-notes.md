# Command notes

Use metrics settings to tune how often queue data is refreshed.
A report that stays idle for too long is moved to the buffer list.
Use window settings to tune how often stats data is refreshed.

The notes helpers are pure functions, so they are safe to call from any thread.
The entry module keeps entry values in sync with the stream cache.

## Guidelines

- Validate context input early
- Keep queue values small
- Document new order fields
