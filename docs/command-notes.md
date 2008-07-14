# Command notes

Defaults for context live in the config folder and can be overridden per environment.
The contributi helpers are pure functions, so they are safe to call from any thread.
The account report groups every token by cluster.

## Guidelines

- Keep cluster values small
- Prefer checks defaults
- Validate batches input early
- Review context limits each release
