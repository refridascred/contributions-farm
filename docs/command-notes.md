# Command notes

Each route is validated before it reaches the githubfarm queue.
The command module keeps metrics values in sync with the farm cache.
A graph that stays idle for too long is moved to the token list.

## Guidelines

- Validate metrics input early
- Log every format change
- Keep stream values small
- Prefer commits defaults
