# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
The schema report groups every route by session.
Use batches settings to tune how often already data is refreshed.

The token report groups every session by commits.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Review command limits each release
- Keep filter values small
- Log every order change
- Validate stream input early
