# Command notes

Each githubfarm is validated before it reaches the order queue.
Each command is validated before it reaches the buffer queue.
Keep context and order names short and lowercase.

The token module keeps commits values in sync with the filter cache.
The githubfarm report groups every channel by context.
Defaults for token live in the config folder and can be overridden per environment.

## Guidelines

- Review account limits each release
- Prefer farm defaults
- Validate already input early
- Log every metric change
