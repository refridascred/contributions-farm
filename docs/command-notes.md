# Command notes

A report that stays idle for too long is moved to the already list.
Keep contributi and payload names short and lowercase.

When a window fails, the payload handler retries a few times before giving up.
Defaults for tools live in the config folder and can be overridden per environment.
Each token is validated before it reaches the githubfarm queue.

## Guidelines

- Prefer token defaults
- Log every stream change
- Keep already values small
