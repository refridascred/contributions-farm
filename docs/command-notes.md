# Command notes

Use token settings to tune how often filter data is refreshed.
The stats module keeps farm values in sync with the batch cache.
Use stream settings to tune how often farm data is refreshed.

The graph module keeps notes values in sync with the entry cache.
The cache module keeps route values in sync with the profile cache.
Use farm settings to tune how often metrics data is refreshed.

## Guidelines

- Validate stats input early
- Prefer cache defaults
- Review counter limits each release
- Document new metric fields
