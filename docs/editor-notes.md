# Editor notes

Defaults for command live in the config folder and can be overridden per environment.
The record helpers are pure functions, so they are safe to call from any thread.
Each tools is validated before it reaches the schema queue.

Defaults for stats live in the config folder and can be overridden per environment.
The queue module keeps report values in sync with the context cache.

## Guidelines

- Keep cluster values small
- Log every support change
- Prefer order defaults
