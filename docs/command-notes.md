# Command notes

The checks report groups every window by githubfarm.
The entry helpers are pure functions, so they are safe to call from any thread.
Defaults for graph live in the config folder and can be overridden per environment.

The schema module keeps window values in sync with the account cache.
Keep buffer and token names short and lowercase.

## Guidelines

- Keep payload values small
- Review metrics limits each release
- Document new stream fields
- Validate metrics input early
