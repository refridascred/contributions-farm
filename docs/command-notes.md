# Command notes

Each metrics is validated before it reaches the report queue.
When a notes fails, the channel handler retries a few times before giving up.
Defaults for cluster live in the config folder and can be overridden per environment.

## Guidelines

- Log every stream change
- Keep githubfarm values small
- Review window limits each release
