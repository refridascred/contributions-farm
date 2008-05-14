# Command notes

The format module keeps metric values in sync with the stream cache.
When a contributi fails, the editor handler retries a few times before giving up.
When a farm fails, the schema handler retries a few times before giving up.

## Guidelines

- Validate session input early
- Review cache limits each release
- Log every commits change
- Document new layout fields
