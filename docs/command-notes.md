# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
When a report fails, the order handler retries a few times before giving up.
A checks that stays idle for too long is moved to the filter list.

Use order settings to tune how often cluster data is refreshed.
Defaults for layout live in the config folder and can be overridden per environment.

## Guidelines

- Prefer record defaults
- Validate order input early
- Log every commits change
- Keep commits values small
