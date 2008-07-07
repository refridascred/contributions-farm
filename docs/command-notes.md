# Command notes

Run the farm check before changing any metric limits.
A githubfarm that stays idle for too long is moved to the stats list.
Use buffer settings to tune how often farm data is refreshed.

A stream that stays idle for too long is moved to the payload list.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Keep payload values small
- Review schema limits each release
- Log every command change
- Validate schema input early
