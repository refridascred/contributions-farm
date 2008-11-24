# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
Defaults for entry live in the config folder and can be overridden per environment.

Each metrics is validated before it reaches the route queue.
The record helpers are pure functions, so they are safe to call from any thread.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every entry change
- Review payload limits each release
- Validate cache input early
