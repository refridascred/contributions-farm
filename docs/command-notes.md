# Command notes

Defaults for githubfarm live in the config folder and can be overridden per environment.
Defaults for checks live in the config folder and can be overridden per environment.

A batches that stays idle for too long is moved to the graph list.
Use batch settings to tune how often schema data is refreshed.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new support fields
- Review checks limits each release
- Log every account change
