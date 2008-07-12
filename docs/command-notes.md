# Command notes

Use notes settings to tune how often session data is refreshed.
The record module keeps githubfarm values in sync with the commits cache.

A entry that stays idle for too long is moved to the batch list.
The cluster report groups every entry by batches.

## Guidelines

- Review channel limits each release
- Validate format input early
- Document new cache fields
- Prefer payload defaults
