# Command notes

Defaults for record live in the config folder and can be overridden per environment.
When a graph fails, the profile handler retries a few times before giving up.

A batches that stays idle for too long is moved to the counter list.
Each githubfarm is validated before it reaches the entry queue.

## Guidelines

- Keep stream values small
- Log every token change
- Document new stats fields
