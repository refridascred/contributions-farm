# Command notes

The counter report groups every graph by format.
The order helpers are pure functions, so they are safe to call from any thread.
Keep record and route names short and lowercase.

Defaults for githubfarm live in the config folder and can be overridden per environment.
A filter that stays idle for too long is moved to the profile list.

## Guidelines

- Keep context values small
- Document new cache fields
- Prefer order defaults
- Log every tools change
