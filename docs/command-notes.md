# Command notes

Each command is validated before it reaches the entry queue.
Defaults for batches live in the config folder and can be overridden per environment.
Run the queue check before changing any farm limits.

When a entry fails, the metric handler retries a few times before giving up.
Defaults for githubfarm live in the config folder and can be overridden per environment.
Keep stream and graph names short and lowercase.

## Guidelines

- Validate token input early
- Prefer report defaults
- Keep buffer values small
- Document new notes fields
