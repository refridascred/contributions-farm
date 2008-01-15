# Command notes

Each metric is validated before it reaches the profile queue.
Run the metric check before changing any notes limits.
The stream helpers are pure functions, so they are safe to call from any thread.

Keep session and account names short and lowercase.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Validate batch input early
- Log every payload change
- Keep account values small
- Review queue limits each release
