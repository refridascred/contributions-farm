# Command notes

Run the filter check before changing any schema limits.
When a counter fails, the filter handler retries a few times before giving up.
The stats module keeps counter values in sync with the farm cache.

## Guidelines

- Log every support change
- Review notes limits each release
- Keep batches values small
- Validate record input early
