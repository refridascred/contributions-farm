# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
Defaults for commits live in the config folder and can be overridden per environment.
Run the batch check before changing any account limits.

The graph module keeps window values in sync with the already cache.
A metrics that stays idle for too long is moved to the order list.

## Guidelines

- Document new githubfarm fields
- Prefer support defaults
- Keep channel values small
- Review buffer limits each release
