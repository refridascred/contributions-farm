# Command notes

Run the profile check before changing any githubfarm limits.
The cluster helpers are pure functions, so they are safe to call from any thread.
Run the profile check before changing any buffer limits.

Use editor settings to tune how often format data is refreshed.
Defaults for command live in the config folder and can be overridden per environment.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review cache limits each release
- Prefer entry defaults
- Log every order change
