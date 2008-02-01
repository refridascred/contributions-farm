# Command notes

A window that stays idle for too long is moved to the already list.
When a batches fails, the filter handler retries a few times before giving up.

Run the entry check before changing any farm limits.
The payload helpers are pure functions, so they are safe to call from any thread.
The window module keeps command values in sync with the route cache.

## Guidelines

- Log every tools change
- Validate profile input early
- Document new command fields
- Prefer channel defaults
