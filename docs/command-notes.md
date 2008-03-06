# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
Defaults for batch live in the config folder and can be overridden per environment.

A report that stays idle for too long is moved to the githubfarm list.
Run the schema check before changing any profile limits.

## Guidelines

- Document new context fields
- Log every metrics change
- Review contributi limits each release
- Keep schema values small
