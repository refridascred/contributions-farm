# Command notes

Defaults for graph live in the config folder and can be overridden per environment.
The tools module keeps cache values in sync with the token cache.
The already module keeps record values in sync with the entry cache.

Each notes is validated before it reaches the graph queue.
Run the queue check before changing any metrics limits.

## Guidelines

- Prefer support defaults
- Document new tools fields
- Review metric limits each release
