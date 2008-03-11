# Command notes

The commits module keeps commits values in sync with the order cache.
Each payload is validated before it reaches the githubfarm queue.

Each stats is validated before it reaches the window queue.
Keep counter and profile names short and lowercase.
A context that stays idle for too long is moved to the schema list.

## Guidelines

- Prefer schema defaults
- Keep route values small
- Validate tools input early
