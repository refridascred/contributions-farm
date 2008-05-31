# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
The metrics helpers are pure functions, so they are safe to call from any thread.
Run the already check before changing any already limits.

Each profile is validated before it reaches the batch queue.
Defaults for counter live in the config folder and can be overridden per environment.
The payload report groups every session by stats.

## Guidelines

- Prefer layout defaults
- Validate notes input early
- Keep token values small
- Review stream limits each release
