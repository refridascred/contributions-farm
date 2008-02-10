# Command notes

The checks report groups every already by layout.
Keep window and farm names short and lowercase.
The support helpers are pure functions, so they are safe to call from any thread.

When a counter fails, the layout handler retries a few times before giving up.
Each notes is validated before it reaches the channel queue.

## Guidelines

- Review token limits each release
- Prefer token defaults
- Keep batch values small
- Log every order change
