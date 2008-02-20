# Command notes

The batches module keeps buffer values in sync with the tools cache.
When a cache fails, the profile handler retries a few times before giving up.

The window module keeps queue values in sync with the report cache.
The entry module keeps graph values in sync with the report cache.
A entry that stays idle for too long is moved to the stats list.

## Guidelines

- Validate notes input early
- Prefer githubfarm defaults
- Review githubfarm limits each release
