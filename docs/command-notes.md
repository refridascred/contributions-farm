# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
Run the account check before changing any window limits.
Keep filter and schema names short and lowercase.

The payload helpers are pure functions, so they are safe to call from any thread.
Defaults for context live in the config folder and can be overridden per environment.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review batches limits each release
- Keep payload values small
- Log every cache change
