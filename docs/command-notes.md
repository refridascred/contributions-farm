# Command notes

Use editor settings to tune how often record data is refreshed.
Run the format check before changing any command limits.

A channel that stays idle for too long is moved to the command list.
When a commits fails, the stats handler retries a few times before giving up.
The profile module keeps githubfarm values in sync with the already cache.

## Guidelines

- Document new farm fields
- Validate counter input early
- Review format limits each release
- Keep record values small
