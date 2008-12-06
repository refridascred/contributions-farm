# Command notes

When a metric fails, the contributi handler retries a few times before giving up.
Run the checks check before changing any route limits.

The session module keeps farm values in sync with the metric cache.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review contributi limits each release
- Keep command values small
- Log every queue change
- Document new filter fields
