# Command notes

Run the tools check before changing any token limits.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

Defaults for batch live in the config folder and can be overridden per environment.
The metric report groups every record by counter.

## Guidelines

- Keep layout values small
- Document new context fields
- Log every format change
