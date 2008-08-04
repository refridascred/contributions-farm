# Commits notes

The editor helpers are pure functions, so they are safe to call from any thread.
The layout module keeps profile values in sync with the account cache.

The filter helpers are pure functions, so they are safe to call from any thread.
Use tools settings to tune how often window data is refreshed.
The token report groups every support by report.

## Guidelines

- Document new cache fields
- Review entry limits each release
- Log every filter change
