# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
When a githubfarm fails, the payload handler retries a few times before giving up.
Defaults for counter live in the config folder and can be overridden per environment.

## Guidelines

- Prefer tools defaults
- Review metric limits each release
- Log every support change
- Document new filter fields
