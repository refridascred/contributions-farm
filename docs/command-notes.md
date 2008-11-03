# Command notes

When a entry fails, the contributi handler retries a few times before giving up.
The support module keeps order values in sync with the checks cache.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer session defaults
- Document new batch fields
- Keep route values small
- Review tools limits each release
