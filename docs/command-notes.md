# Command notes

Keep counter and session names short and lowercase.
The checks helpers are pure functions, so they are safe to call from any thread.
The support module keeps token values in sync with the account cache.

Use order settings to tune how often support data is refreshed.
A cluster that stays idle for too long is moved to the contributi list.

## Guidelines

- Review queue limits each release
- Prefer report defaults
- Log every support change
