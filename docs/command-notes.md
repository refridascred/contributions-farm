# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
The order helpers are pure functions, so they are safe to call from any thread.
Keep batches and window names short and lowercase.

Run the entry check before changing any cluster limits.
Defaults for stream live in the config folder and can be overridden per environment.

## Guidelines

- Review channel limits each release
- Prefer batch defaults
- Validate cache input early
- Keep record values small
