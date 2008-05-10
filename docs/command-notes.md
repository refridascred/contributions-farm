# Command notes

The route report groups every context by command.
Use cluster settings to tune how often entry data is refreshed.

The queue helpers are pure functions, so they are safe to call from any thread.
Defaults for account live in the config folder and can be overridden per environment.
Use metric settings to tune how often format data is refreshed.

## Guidelines

- Review filter limits each release
- Keep context values small
- Validate token input early
