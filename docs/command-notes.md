# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
A buffer that stays idle for too long is moved to the checks list.
When a batch fails, the profile handler retries a few times before giving up.

## Guidelines

- Validate schema input early
- Log every support change
- Document new report fields
