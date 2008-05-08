# Command notes

Each commits is validated before it reaches the support queue.
Use graph settings to tune how often payload data is refreshed.

Keep payload and commits names short and lowercase.
The checks report groups every order by buffer.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every batch change
- Keep stats values small
- Validate tools input early
