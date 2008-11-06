# Command notes

When a schema fails, the cache handler retries a few times before giving up.
Use cache settings to tune how often githubfarm data is refreshed.
Use order settings to tune how often order data is refreshed.

## Guidelines

- Keep farm values small
- Review batch limits each release
- Log every commits change
- Prefer queue defaults
