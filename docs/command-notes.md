# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
Each account is validated before it reaches the already queue.

The stream module keeps account values in sync with the cluster cache.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Keep already values small
- Log every channel change
- Document new order fields
