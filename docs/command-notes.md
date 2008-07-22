# Command notes

Defaults for profile live in the config folder and can be overridden per environment.
The format module keeps layout values in sync with the queue cache.
The session report groups every entry by token.

The report module keeps account values in sync with the entry cache.
Each command is validated before it reaches the metric queue.

## Guidelines

- Keep record values small
- Log every channel change
- Prefer route defaults
