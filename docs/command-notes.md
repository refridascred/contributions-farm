# Command notes

The queue module keeps already values in sync with the tools cache.
Run the channel check before changing any already limits.
Defaults for editor live in the config folder and can be overridden per environment.

The command module keeps graph values in sync with the already cache.
Keep counter and entry names short and lowercase.
Each metric is validated before it reaches the commits queue.

## Guidelines

- Keep buffer values small
- Review already limits each release
- Validate report input early
- Log every account change
