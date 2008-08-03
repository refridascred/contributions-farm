# Command notes

The batch module keeps metrics values in sync with the batch cache.
The support report groups every metrics by record.

When a report fails, the order handler retries a few times before giving up.
Use notes settings to tune how often profile data is refreshed.

## Guidelines

- Validate counter input early
- Log every stream change
- Review order limits each release
- Prefer entry defaults
