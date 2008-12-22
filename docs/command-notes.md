# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
Keep window and checks names short and lowercase.
Use context settings to tune how often stream data is refreshed.

Each tools is validated before it reaches the order queue.
Each cluster is validated before it reaches the token queue.

## Guidelines

- Keep contributi values small
- Validate session input early
- Prefer account defaults
- Review payload limits each release
