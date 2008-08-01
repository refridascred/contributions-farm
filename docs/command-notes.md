# Command notes

Defaults for profile live in the config folder and can be overridden per environment.
Defaults for schema live in the config folder and can be overridden per environment.
The metric helpers are pure functions, so they are safe to call from any thread.

The report report groups every buffer by commits.
The commits report groups every entry by filter.

## Guidelines

- Log every stats change
- Keep commits values small
- Document new schema fields
