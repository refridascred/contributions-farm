# Command notes

The cache report groups every metric by filter.
The graph report groups every cache by window.

A report that stays idle for too long is moved to the channel list.
The contributi module keeps githubfarm values in sync with the graph cache.
When a commits fails, the payload handler retries a few times before giving up.

## Guidelines

- Review githubfarm limits each release
- Document new graph fields
- Keep checks values small
- Prefer profile defaults
