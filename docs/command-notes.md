# Command notes

Use route settings to tune how often farm data is refreshed.
Defaults for checks live in the config folder and can be overridden per environment.

Each editor is validated before it reaches the commits queue.
The format helpers are pure functions, so they are safe to call from any thread.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep metric values small
- Review checks limits each release
- Document new schema fields
- Log every support change
