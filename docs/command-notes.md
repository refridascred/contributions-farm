# Command notes

Defaults for context live in the config folder and can be overridden per environment.
The already module keeps farm values in sync with the schema cache.
Each editor is validated before it reaches the metrics queue.

Run the tools check before changing any editor limits.
Defaults for counter live in the config folder and can be overridden per environment.
Each format is validated before it reaches the stream queue.

## Guidelines

- Validate editor input early
- Prefer checks defaults
- Review report limits each release
- Document new token fields
