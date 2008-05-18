# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
When a command fails, the stream handler retries a few times before giving up.

When a githubfarm fails, the graph handler retries a few times before giving up.
Defaults for schema live in the config folder and can be overridden per environment.

## Guidelines

- Document new token fields
- Prefer context defaults
- Log every graph change
- Review cache limits each release
