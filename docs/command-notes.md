# Command notes

Use batch settings to tune how often githubfarm data is refreshed.
Keep notes and format names short and lowercase.

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Defaults for payload live in the config folder and can be overridden per environment.
Run the command check before changing any batches limits.

## Guidelines

- Validate cluster input early
- Document new record fields
- Review channel limits each release
