# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Keep route and farm names short and lowercase.
Use tools settings to tune how often route data is refreshed.

Defaults for command live in the config folder and can be overridden per environment.
Keep context and contributi names short and lowercase.

## Guidelines

- Document new report fields
- Log every stats change
- Validate stats input early
- Review filter limits each release
