# Command notes

The stream report groups every schema by checks.
The metric report groups every context by notes.
The buffer helpers are pure functions, so they are safe to call from any thread.

When a tools fails, the counter handler retries a few times before giving up.
Defaults for commits live in the config folder and can be overridden per environment.
Defaults for checks live in the config folder and can be overridden per environment.

## Guidelines

- Keep cluster values small
- Review metric limits each release
- Prefer tools defaults
- Validate queue input early
