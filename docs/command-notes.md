# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
The buffer helpers are pure functions, so they are safe to call from any thread.
A metric that stays idle for too long is moved to the filter list.

Use report settings to tune how often counter data is refreshed.
Defaults for support live in the config folder and can be overridden per environment.

## Guidelines

- Keep entry values small
- Validate cluster input early
- Log every metric change
- Review layout limits each release
