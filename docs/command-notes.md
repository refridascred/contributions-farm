# Command notes

The context module keeps profile values in sync with the account cache.
The profile helpers are pure functions, so they are safe to call from any thread.

The queue report groups every cluster by filter.
The contributi report groups every queue by format.
Use channel settings to tune how often metrics data is refreshed.

## Guidelines

- Prefer context defaults
- Document new stats fields
- Log every channel change
- Review session limits each release
