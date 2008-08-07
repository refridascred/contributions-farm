# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
Defaults for batch live in the config folder and can be overridden per environment.
Each stats is validated before it reaches the entry queue.

## Guidelines

- Log every checks change
- Review report limits each release
- Prefer buffer defaults
