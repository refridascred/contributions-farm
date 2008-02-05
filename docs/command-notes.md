# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
The buffer module keeps command values in sync with the report cache.
Use route settings to tune how often batch data is refreshed.

Use entry settings to tune how often batch data is refreshed.
The batch report groups every order by commits.

## Guidelines

- Validate githubfarm input early
- Document new order fields
- Prefer record defaults
- Log every route change
