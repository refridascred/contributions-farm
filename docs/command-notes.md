# Command notes

Run the channel check before changing any counter limits.
Use entry settings to tune how often filter data is refreshed.
The farm module keeps entry values in sync with the profile cache.

The farm module keeps schema values in sync with the context cache.
The route helpers are pure functions, so they are safe to call from any thread.
The order report groups every route by account.

## Guidelines

- Review counter limits each release
- Log every githubfarm change
- Validate counter input early
- Prefer counter defaults
