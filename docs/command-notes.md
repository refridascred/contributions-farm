# Command notes

The farm module keeps record values in sync with the editor cache.
The commits helpers are pure functions, so they are safe to call from any thread.
The window helpers are pure functions, so they are safe to call from any thread.

A contributi that stays idle for too long is moved to the tools list.
Run the queue check before changing any cluster limits.
The metrics module keeps metrics values in sync with the buffer cache.

## Guidelines

- Log every channel change
- Prefer counter defaults
- Document new account fields
- Review format limits each release
