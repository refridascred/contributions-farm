# Command notes

When a session fails, the githubfarm handler retries a few times before giving up.
Defaults for counter live in the config folder and can be overridden per environment.

## Guidelines

- Review buffer limits each release
- Keep graph values small
- Log every farm change
