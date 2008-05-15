# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Log every cache change
- Document new filter fields
- Validate context input early
