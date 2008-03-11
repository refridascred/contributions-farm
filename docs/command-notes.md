# Command notes

Use notes settings to tune how often report data is refreshed.
Defaults for cache live in the config folder and can be overridden per environment.
The filter module keeps already values in sync with the metrics cache.

Run the metric check before changing any tools limits.
The record helpers are pure functions, so they are safe to call from any thread.
Use notes settings to tune how often batches data is refreshed.

## Guidelines

- Review cache limits each release
- Prefer already defaults
- Log every cluster change
- Validate session input early
