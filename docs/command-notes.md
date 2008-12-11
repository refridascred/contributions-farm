# Command notes

Use layout settings to tune how often stream data is refreshed.
Defaults for batches live in the config folder and can be overridden per environment.

Each farm is validated before it reaches the filter queue.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer already defaults
- Validate stats input early
- Document new checks fields
