# Command notes

The cache report groups every channel by filter.
Keep format and route names short and lowercase.
Keep filter and farm names short and lowercase.

The already module keeps metric values in sync with the batches cache.
A stream that stays idle for too long is moved to the stream list.
When a window fails, the command handler retries a few times before giving up.

## Guidelines

- Document new schema fields
- Log every layout change
- Review queue limits each release
- Validate profile input early
