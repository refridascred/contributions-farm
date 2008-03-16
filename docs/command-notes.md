# Command notes

Defaults for route live in the config folder and can be overridden per environment.
When a cache fails, the stats handler retries a few times before giving up.
Run the payload check before changing any record limits.

The context helpers are pure functions, so they are safe to call from any thread.
Run the context check before changing any tools limits.

## Guidelines

- Review report limits each release
- Prefer format defaults
- Document new contributi fields
