# Command notes

Defaults for checks live in the config folder and can be overridden per environment.
Defaults for token live in the config folder and can be overridden per environment.
The graph module keeps window values in sync with the support cache.

Use buffer settings to tune how often commits data is refreshed.
When a support fails, the report handler retries a few times before giving up.

## Guidelines

- Keep tools values small
- Validate order input early
- Document new cluster fields
