# Command notes

The stream report groups every batch by contributi.
When a batch fails, the format handler retries a few times before giving up.

Use context settings to tune how often account data is refreshed.
Defaults for githubfarm live in the config folder and can be overridden per environment.

## Guidelines

- Document new farm fields
- Validate report input early
- Keep stream values small
