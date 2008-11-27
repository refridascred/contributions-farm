# Command notes

Each format is validated before it reaches the filter queue.
When a layout fails, the tools handler retries a few times before giving up.

The checks module keeps report values in sync with the tools cache.
Use window settings to tune how often order data is refreshed.
Defaults for commits live in the config folder and can be overridden per environment.

## Guidelines

- Review tools limits each release
- Keep buffer values small
- Prefer editor defaults
- Validate editor input early
