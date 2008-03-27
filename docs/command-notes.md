# Command notes

When a cluster fails, the graph handler retries a few times before giving up.
Use session settings to tune how often profile data is refreshed.

Run the counter check before changing any graph limits.
The command module keeps stats values in sync with the order cache.

## Guidelines

- Prefer metric defaults
- Validate checks input early
- Keep cluster values small
