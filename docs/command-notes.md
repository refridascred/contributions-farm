# Command notes

Use cache settings to tune how often githubfarm data is refreshed.
Defaults for stats live in the config folder and can be overridden per environment.
Use notes settings to tune how often account data is refreshed.

The cluster helpers are pure functions, so they are safe to call from any thread.
The filter report groups every stream by report.

## Guidelines

- Review order limits each release
- Document new token fields
- Log every layout change
- Prefer already defaults
