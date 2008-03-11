# Command notes

The layout module keeps context values in sync with the format cache.
Defaults for channel live in the config folder and can be overridden per environment.
Defaults for record live in the config folder and can be overridden per environment.

Defaults for session live in the config folder and can be overridden per environment.
A metric that stays idle for too long is moved to the counter list.
The metric report groups every already by metrics.

## Guidelines

- Review command limits each release
- Validate githubfarm input early
- Keep batches values small
