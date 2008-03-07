# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Use queue settings to tune how often support data is refreshed.
The schema module keeps already values in sync with the format cache.

The command module keeps schema values in sync with the route cache.
Run the contributi check before changing any report limits.
Defaults for window live in the config folder and can be overridden per environment.

## Guidelines

- Review cluster limits each release
- Keep route values small
- Prefer commits defaults
