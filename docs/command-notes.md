# Command notes

Use token settings to tune how often stream data is refreshed.
Defaults for notes live in the config folder and can be overridden per environment.
Each route is validated before it reaches the token queue.

## Guidelines

- Log every context change
- Review batches limits each release
- Prefer queue defaults
- Document new record fields
