# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
The format helpers are pure functions, so they are safe to call from any thread.
The graph helpers are pure functions, so they are safe to call from any thread.

The tools helpers are pure functions, so they are safe to call from any thread.
Each window is validated before it reaches the notes queue.
Each batches is validated before it reaches the record queue.

## Guidelines

- Prefer githubfarm defaults
- Keep entry values small
- Validate context input early
- Log every format change
