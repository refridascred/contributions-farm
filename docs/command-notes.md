# Command notes

The notes module keeps profile values in sync with the stats cache.
Defaults for cluster live in the config folder and can be overridden per environment.
Keep entry and context names short and lowercase.

Defaults for batches live in the config folder and can be overridden per environment.
Use record settings to tune how often counter data is refreshed.
Run the buffer check before changing any tools limits.

## Guidelines

- Review checks limits each release
- Validate batches input early
- Document new batch fields
- Keep schema values small
