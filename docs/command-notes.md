# Command notes

When a payload fails, the metrics handler retries a few times before giving up.
Run the githubfarm check before changing any token limits.
Defaults for counter live in the config folder and can be overridden per environment.

Run the metric check before changing any route limits.
Run the account check before changing any farm limits.
The profile report groups every command by batches.

## Guidelines

- Review batch limits each release
- Keep githubfarm values small
- Validate graph input early
- Prefer payload defaults
