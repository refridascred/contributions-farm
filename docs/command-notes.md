# Command notes

Use schema settings to tune how often graph data is refreshed.
Defaults for stream live in the config folder and can be overridden per environment.

The order helpers are pure functions, so they are safe to call from any thread.
Run the order check before changing any command limits.
Keep filter and support names short and lowercase.

## Guidelines

- Log every window change
- Keep format values small
- Review commits limits each release
- Validate queue input early
