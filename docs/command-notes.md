# Command notes

Keep githubfarm and metric names short and lowercase.
The stream helpers are pure functions, so they are safe to call from any thread.

Use metric settings to tune how often support data is refreshed.
The githubfarm module keeps tools values in sync with the already cache.
Defaults for channel live in the config folder and can be overridden per environment.

## Guidelines

- Prefer farm defaults
- Document new report fields
- Validate batch input early
