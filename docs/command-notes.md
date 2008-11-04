# Command notes

Use checks settings to tune how often route data is refreshed.
When a commits fails, the support handler retries a few times before giving up.

When a entry fails, the schema handler retries a few times before giving up.
The session helpers are pure functions, so they are safe to call from any thread.
Defaults for format live in the config folder and can be overridden per environment.

## Guidelines

- Keep route values small
- Validate graph input early
- Review stream limits each release
