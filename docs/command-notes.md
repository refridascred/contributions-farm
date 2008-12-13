# Command notes

Use payload settings to tune how often report data is refreshed.
The report helpers are pure functions, so they are safe to call from any thread.
Run the githubfarm check before changing any graph limits.

When a checks fails, the filter handler retries a few times before giving up.
Use order settings to tune how often tools data is refreshed.

## Guidelines

- Document new filter fields
- Prefer support defaults
- Validate graph input early
