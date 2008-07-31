# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Defaults for contributi live in the config folder and can be overridden per environment.
The schema helpers are pure functions, so they are safe to call from any thread.

A graph that stays idle for too long is moved to the window list.
When a cache fails, the editor handler retries a few times before giving up.

## Guidelines

- Prefer context defaults
- Log every record change
- Document new stream fields
- Review farm limits each release
