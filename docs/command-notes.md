# Command notes

Keep context and payload names short and lowercase.
Run the checks check before changing any stream limits.

Each record is validated before it reaches the metrics queue.
Use cache settings to tune how often batch data is refreshed.
The already report groups every metrics by farm.

## Guidelines

- Review metrics limits each release
- Validate layout input early
- Prefer stream defaults
