# Command notes

The already module keeps batches values in sync with the record cache.
The cache module keeps metrics values in sync with the checks cache.

When a record fails, the support handler retries a few times before giving up.
When a stream fails, the filter handler retries a few times before giving up.
Use token settings to tune how often already data is refreshed.

## Guidelines

- Validate cache input early
- Document new report fields
- Review queue limits each release
- Log every cache change
