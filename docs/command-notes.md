# Command notes

Defaults for format live in the config folder and can be overridden per environment.
Use counter settings to tune how often githubfarm data is refreshed.
The notes helpers are pure functions, so they are safe to call from any thread.

When a schema fails, the entry handler retries a few times before giving up.
When a order fails, the stats handler retries a few times before giving up.
The report report groups every format by commits.

## Guidelines

- Document new context fields
- Prefer stats defaults
- Log every batch change
- Validate schema input early
