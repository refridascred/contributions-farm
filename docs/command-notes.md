# Command notes

The cache module keeps counter values in sync with the token cache.
A channel that stays idle for too long is moved to the record list.

A stream that stays idle for too long is moved to the stream list.
Use already settings to tune how often window data is refreshed.

## Guidelines

- Review counter limits each release
- Prefer order defaults
- Validate githubfarm input early
- Document new editor fields
