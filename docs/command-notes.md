# Command notes

Each support is validated before it reaches the window queue.
The metrics helpers are pure functions, so they are safe to call from any thread.
Keep githubfarm and record names short and lowercase.

The account module keeps account values in sync with the counter cache.
Keep entry and counter names short and lowercase.
Defaults for cluster live in the config folder and can be overridden per environment.

## Guidelines

- Log every metrics change
- Validate checks input early
- Document new report fields
- Prefer layout defaults
