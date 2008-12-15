# Command notes

Each cluster is validated before it reaches the batches queue.
Defaults for report live in the config folder and can be overridden per environment.
Use counter settings to tune how often buffer data is refreshed.

## Guidelines

- Document new batch fields
- Keep schema values small
- Log every queue change
- Prefer commits defaults
