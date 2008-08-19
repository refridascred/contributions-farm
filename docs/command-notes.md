# Command notes

Use payload settings to tune how often buffer data is refreshed.
The format helpers are pure functions, so they are safe to call from any thread.
Keep session and route names short and lowercase.

The counter report groups every command by cache.
Run the counter check before changing any context limits.
Defaults for stream live in the config folder and can be overridden per environment.

## Guidelines

- Review format limits each release
- Log every queue change
- Validate farm input early
