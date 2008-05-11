# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
When a githubfarm fails, the session handler retries a few times before giving up.
The record report groups every context by stats.

Keep command and metrics names short and lowercase.
A buffer that stays idle for too long is moved to the command list.

## Guidelines

- Prefer order defaults
- Document new record fields
- Review report limits each release
- Log every payload change
