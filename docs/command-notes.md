# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
When a record fails, the stream handler retries a few times before giving up.
The support module keeps batches values in sync with the stats cache.

The batches module keeps commits values in sync with the editor cache.
Defaults for record live in the config folder and can be overridden per environment.

## Guidelines

- Prefer support defaults
- Validate profile input early
- Document new counter fields
- Review cluster limits each release
