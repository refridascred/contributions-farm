# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Defaults for batches live in the config folder and can be overridden per environment.
A buffer that stays idle for too long is moved to the metric list.

Use stats settings to tune how often farm data is refreshed.
The graph report groups every metrics by contributi.

## Guidelines

- Validate context input early
- Prefer graph defaults
- Keep report values small
- Log every report change
