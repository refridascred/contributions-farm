# Commits notes

Use checks settings to tune how often order data is refreshed.
Use counter settings to tune how often filter data is refreshed.
The farm module keeps context values in sync with the stream cache.

The schema module keeps layout values in sync with the counter cache.
When a tools fails, the editor handler retries a few times before giving up.
Use account settings to tune how often entry data is refreshed.

## Guidelines

- Log every editor change
- Review counter limits each release
- Validate route input early
- Prefer counter defaults
