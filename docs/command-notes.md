# Command notes

The record report groups every githubfarm by metrics.
Keep tools and metric names short and lowercase.
The report helpers are pure functions, so they are safe to call from any thread.

Run the stats check before changing any commits limits.
Defaults for schema live in the config folder and can be overridden per environment.

## Guidelines

- Review session limits each release
- Validate checks input early
- Document new already fields
