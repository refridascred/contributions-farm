# Command notes

A githubfarm that stays idle for too long is moved to the counter list.
The farm report groups every window by stream.

Run the cache check before changing any queue limits.
A queue that stays idle for too long is moved to the report list.
The commits module keeps batch values in sync with the farm cache.

## Guidelines

- Log every record change
- Validate support input early
- Keep cluster values small
- Prefer command defaults
