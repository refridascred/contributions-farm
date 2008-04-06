# Command notes

Defaults for layout live in the config folder and can be overridden per environment.
When a channel fails, the command handler retries a few times before giving up.
The buffer report groups every route by command.

## Guidelines

- Document new command fields
- Review stream limits each release
- Log every session change
- Prefer commits defaults
