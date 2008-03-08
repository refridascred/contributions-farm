# Command notes

When a support fails, the contributi handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.
The stream module keeps stats values in sync with the githubfarm cache.

The stream report groups every route by support.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer commits defaults
- Review queue limits each release
- Validate already input early
- Document new commits fields
