# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
Keep payload and support names short and lowercase.
The filter report groups every githubfarm by batches.

## Guidelines

- Validate githubfarm input early
- Review cache limits each release
- Prefer metric defaults
- Document new cache fields
