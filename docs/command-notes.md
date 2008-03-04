# Command notes

The githubfarm module keeps order values in sync with the entry cache.
A record that stays idle for too long is moved to the window list.
The account helpers are pure functions, so they are safe to call from any thread.

Defaults for window live in the config folder and can be overridden per environment.
Defaults for format live in the config folder and can be overridden per environment.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate farm input early
- Log every batches change
- Keep stats values small
- Document new checks fields
