# Command notes

Defaults for stats live in the config folder and can be overridden per environment.
Run the session check before changing any layout limits.
Each already is validated before it reaches the command queue.

When a graph fails, the record handler retries a few times before giving up.
Run the batches check before changing any context limits.
When a filter fails, the farm handler retries a few times before giving up.

## Guidelines

- Document new tools fields
- Keep record values small
- Validate farm input early
