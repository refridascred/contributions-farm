# Command notes

A filter that stays idle for too long is moved to the batch list.
Defaults for already live in the config folder and can be overridden per environment.
When a account fails, the payload handler retries a few times before giving up.

## Guidelines

- Document new githubfarm fields
- Validate session input early
- Keep channel values small
