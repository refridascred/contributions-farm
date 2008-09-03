# Command notes

Defaults for checks live in the config folder and can be overridden per environment.
The support report groups every payload by window.
Defaults for payload live in the config folder and can be overridden per environment.

A githubfarm that stays idle for too long is moved to the stream list.
A batches that stays idle for too long is moved to the schema list.

## Guidelines

- Document new support fields
- Validate filter input early
- Log every stats change
