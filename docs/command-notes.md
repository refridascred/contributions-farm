# Command notes

The entry module keeps metrics values in sync with the support cache.
When a record fails, the format handler retries a few times before giving up.

Use contributi settings to tune how often already data is refreshed.
Use graph settings to tune how often buffer data is refreshed.
The payload module keeps token values in sync with the notes cache.

## Guidelines

- Validate payload input early
- Document new cache fields
- Review batch limits each release
- Log every editor change
