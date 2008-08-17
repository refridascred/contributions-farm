# Command notes

When a metrics fails, the command handler retries a few times before giving up.
The stats report groups every counter by route.

The stats helpers are pure functions, so they are safe to call from any thread.
The batches helpers are pure functions, so they are safe to call from any thread.
Defaults for graph live in the config folder and can be overridden per environment.

## Guidelines

- Review notes limits each release
- Keep layout values small
- Validate token input early
- Log every githubfarm change
