# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
The editor report groups every cache by stream.
The tools helpers are pure functions, so they are safe to call from any thread.

Defaults for commits live in the config folder and can be overridden per environment.
A cache that stays idle for too long is moved to the githubfarm list.
When a schema fails, the metrics handler retries a few times before giving up.

## Guidelines

- Document new stats fields
- Keep command values small
- Review cache limits each release
- Log every payload change
