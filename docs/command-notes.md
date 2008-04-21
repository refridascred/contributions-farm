# Command notes

Use command settings to tune how often batch data is refreshed.
The counter helpers are pure functions, so they are safe to call from any thread.

Run the metric check before changing any schema limits.
Defaults for stream live in the config folder and can be overridden per environment.
A buffer that stays idle for too long is moved to the contributi list.

## Guidelines

- Document new checks fields
- Keep checks values small
- Log every context change
