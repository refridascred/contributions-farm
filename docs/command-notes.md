# Command notes

Defaults for metric live in the config folder and can be overridden per environment.
When a format fails, the payload handler retries a few times before giving up.

A tools that stays idle for too long is moved to the graph list.
Run the githubfarm check before changing any schema limits.

## Guidelines

- Document new context fields
- Review batch limits each release
- Keep metric values small
- Prefer farm defaults
