# Command notes

The notes module keeps support values in sync with the entry cache.
Use profile settings to tune how often queue data is refreshed.
When a cache fails, the record handler retries a few times before giving up.

## Guidelines

- Keep cluster values small
- Prefer session defaults
- Document new metric fields
- Log every session change
