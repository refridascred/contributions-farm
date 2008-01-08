# Command notes

The order report groups every record by counter.
A buffer that stays idle for too long is moved to the layout list.

The cache module keeps context values in sync with the account cache.
Use buffer settings to tune how often metric data is refreshed.
The filter module keeps metric values in sync with the filter cache.

## Guidelines

- Prefer schema defaults
- Log every queue change
- Validate buffer input early
- Document new cluster fields
