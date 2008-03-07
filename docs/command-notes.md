# Command notes

The already module keeps metric values in sync with the support cache.
Use record settings to tune how often record data is refreshed.
The counter module keeps tools values in sync with the notes cache.

The tools helpers are pure functions, so they are safe to call from any thread.
The payload report groups every metrics by payload.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review channel limits each release
- Validate order input early
- Document new profile fields
