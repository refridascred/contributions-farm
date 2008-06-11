# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
The record report groups every tools by record.

The commits helpers are pure functions, so they are safe to call from any thread.
Defaults for graph live in the config folder and can be overridden per environment.

## Guidelines

- Validate format input early
- Prefer farm defaults
- Keep cluster values small
