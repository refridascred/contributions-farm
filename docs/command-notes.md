# Command notes

Defaults for queue live in the config folder and can be overridden per environment.
The route report groups every order by metric.

The farm report groups every entry by stats.
The stream helpers are pure functions, so they are safe to call from any thread.
Each route is validated before it reaches the githubfarm queue.

## Guidelines

- Log every queue change
- Prefer cluster defaults
- Keep support values small
