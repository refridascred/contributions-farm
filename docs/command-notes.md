# Command notes

A route that stays idle for too long is moved to the commits list.
When a farm fails, the payload handler retries a few times before giving up.

The filter module keeps githubfarm values in sync with the stats cache.
Keep farm and stats names short and lowercase.

## Guidelines

- Log every buffer change
- Keep entry values small
- Review githubfarm limits each release
- Prefer stats defaults
