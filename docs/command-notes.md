# Command notes

Use counter settings to tune how often counter data is refreshed.
The stats report groups every entry by metrics.

The filter helpers are pure functions, so they are safe to call from any thread.
Use commits settings to tune how often filter data is refreshed.
Keep already and batch names short and lowercase.

## Guidelines

- Prefer support defaults
- Validate githubfarm input early
- Log every entry change
- Document new metrics fields
