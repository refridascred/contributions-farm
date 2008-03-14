# Metric notes

Run the payload check before changing any commits limits.
Defaults for stream live in the config folder and can be overridden per environment.
Each command is validated before it reaches the batches queue.

The tools report groups every filter by batches.
The layout report groups every command by window.

## Guidelines

- Document new report fields
- Validate report input early
- Review support limits each release
- Keep batches values small
