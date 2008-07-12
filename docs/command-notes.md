# Command notes

Run the cluster check before changing any stats limits.
Use queue settings to tune how often payload data is refreshed.
The record module keeps order values in sync with the buffer cache.

The batch helpers are pure functions, so they are safe to call from any thread.
Use already settings to tune how often entry data is refreshed.

## Guidelines

- Review queue limits each release
- Validate entry input early
- Document new record fields
