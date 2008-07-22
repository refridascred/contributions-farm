# Command notes

Run the batch check before changing any payload limits.
Run the filter check before changing any cluster limits.
The layout report groups every cluster by checks.

When a buffer fails, the stream handler retries a few times before giving up.
The schema helpers are pure functions, so they are safe to call from any thread.
Defaults for commits live in the config folder and can be overridden per environment.

## Guidelines

- Prefer stream defaults
- Validate command input early
- Keep profile values small
- Log every contributi change
