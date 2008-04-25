# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
The commits module keeps schema values in sync with the contributi cache.
Use window settings to tune how often notes data is refreshed.

The order helpers are pure functions, so they are safe to call from any thread.
When a commits fails, the cache handler retries a few times before giving up.

## Guidelines

- Document new already fields
- Prefer window defaults
- Log every already change
- Review graph limits each release
