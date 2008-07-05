# Command notes

Run the already check before changing any filter limits.
Defaults for editor live in the config folder and can be overridden per environment.
When a route fails, the session handler retries a few times before giving up.

Run the stream check before changing any schema limits.
Defaults for record live in the config folder and can be overridden per environment.
The editor module keeps contributi values in sync with the order cache.

## Guidelines

- Log every report change
- Prefer support defaults
- Document new schema fields
- Review counter limits each release
