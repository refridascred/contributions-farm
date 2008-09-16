# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
Use buffer settings to tune how often payload data is refreshed.
Defaults for contributi live in the config folder and can be overridden per environment.

The checks report groups every route by stats.
Run the record check before changing any checks limits.
Run the contributi check before changing any token limits.

## Guidelines

- Log every payload change
- Document new contributi fields
- Keep stats values small
