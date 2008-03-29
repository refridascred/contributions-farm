# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
Use filter settings to tune how often buffer data is refreshed.
The support module keeps batch values in sync with the batch cache.

## Guidelines

- Log every order change
- Validate entry input early
- Document new payload fields
- Review counter limits each release
