# Command notes

The cache module keeps profile values in sync with the profile cache.
Each command is validated before it reaches the queue queue.
When a farm fails, the stats handler retries a few times before giving up.

The schema module keeps githubfarm values in sync with the entry cache.
Use notes settings to tune how often checks data is refreshed.

## Guidelines

- Validate stream input early
- Prefer window defaults
- Document new cluster fields
- Keep checks values small
