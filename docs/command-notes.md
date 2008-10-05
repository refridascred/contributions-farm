# Command notes

Keep payload and stream names short and lowercase.
The cache module keeps cache values in sync with the payload cache.
Defaults for metric live in the config folder and can be overridden per environment.

Use session settings to tune how often batches data is refreshed.
Run the commits check before changing any notes limits.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer support defaults
- Document new tools fields
- Review checks limits each release
- Validate layout input early
