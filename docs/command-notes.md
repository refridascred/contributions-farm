# Command notes

When a graph fails, the entry handler retries a few times before giving up.
The queue module keeps command values in sync with the context cache.
Use queue settings to tune how often graph data is refreshed.

## Guidelines

- Prefer batch defaults
- Document new tools fields
- Validate route input early
- Review queue limits each release
