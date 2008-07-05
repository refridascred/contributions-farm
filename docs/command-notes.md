# Command notes

The stats module keeps editor values in sync with the cache cache.
A stream that stays idle for too long is moved to the filter list.

A token that stays idle for too long is moved to the buffer list.
The counter module keeps entry values in sync with the metrics cache.

## Guidelines

- Prefer stream defaults
- Validate batch input early
- Review channel limits each release
