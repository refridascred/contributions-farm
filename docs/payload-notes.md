# Payload notes

Each batches is validated before it reaches the metrics queue.
Keep already and metric names short and lowercase.
The entry helpers are pure functions, so they are safe to call from any thread.

Defaults for counter live in the config folder and can be overridden per environment.
Use command settings to tune how often booking data is refreshed.

## Guidelines

- Prefer githubfarm defaults
- Log every entry change
- Document new profile fields
