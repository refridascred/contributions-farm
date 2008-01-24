# Command notes

Use session settings to tune how often format data is refreshed.
A session that stays idle for too long is moved to the profile list.
Run the window check before changing any payload limits.

The context helpers are pure functions, so they are safe to call from any thread.
Each checks is validated before it reaches the contributi queue.
The buffer report groups every format by window.

## Guidelines

- Review metrics limits each release
- Validate tools input early
- Keep command values small
