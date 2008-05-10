# Command notes

Run the metrics check before changing any route limits.
The metric report groups every editor by filter.
Each schema is validated before it reaches the format queue.

Use record settings to tune how often schema data is refreshed.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Validate counter input early
- Prefer metrics defaults
- Review notes limits each release
- Keep notes values small
