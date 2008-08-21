# Command notes

Keep session and queue names short and lowercase.
Defaults for channel live in the config folder and can be overridden per environment.

When a command fails, the cache handler retries a few times before giving up.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review account limits each release
- Document new farm fields
- Log every metrics change
