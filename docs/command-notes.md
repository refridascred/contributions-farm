# Command notes

A schema that stays idle for too long is moved to the entry list.
Defaults for githubfarm live in the config folder and can be overridden per environment.

Each filter is validated before it reaches the stream queue.
The checks helpers are pure functions, so they are safe to call from any thread.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Keep profile values small
- Document new channel fields
- Log every batch change
