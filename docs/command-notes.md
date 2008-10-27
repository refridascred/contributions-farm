# Command notes

Use batches settings to tune how often account data is refreshed.
The filter helpers are pure functions, so they are safe to call from any thread.

The tools report groups every tools by metric.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Validate filter input early
- Document new account fields
- Review commits limits each release
- Keep counter values small
