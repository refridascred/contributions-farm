# Command notes

Each profile is validated before it reaches the tools queue.
Defaults for support live in the config folder and can be overridden per environment.

Each context is validated before it reaches the already queue.
The batches helpers are pure functions, so they are safe to call from any thread.
Use contributi settings to tune how often route data is refreshed.

## Guidelines

- Prefer order defaults
- Review metric limits each release
- Document new account fields
- Validate channel input early
