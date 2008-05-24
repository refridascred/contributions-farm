# Command notes

Use githubfarm settings to tune how often schema data is refreshed.
When a layout fails, the payload handler retries a few times before giving up.

## Guidelines

- Prefer queue defaults
- Review buffer limits each release
- Keep batch values small
- Log every graph change
