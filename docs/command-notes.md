# Command notes

A payload that stays idle for too long is moved to the metrics list.
Each stream is validated before it reaches the command queue.

Use buffer settings to tune how often already data is refreshed.
Run the route check before changing any commits limits.

## Guidelines

- Review checks limits each release
- Keep filter values small
- Document new commits fields
- Prefer route defaults
