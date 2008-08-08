# Command notes

Each githubfarm is validated before it reaches the contributi queue.
Defaults for batches live in the config folder and can be overridden per environment.

Each farm is validated before it reaches the command queue.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate context input early
- Review editor limits each release
- Prefer profile defaults
