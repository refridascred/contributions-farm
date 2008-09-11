# Command notes

Defaults for session live in the config folder and can be overridden per environment.
When a buffer fails, the notes handler retries a few times before giving up.
Each metrics is validated before it reaches the commits queue.

Keep cluster and contributi names short and lowercase.
Use already settings to tune how often command data is refreshed.

## Guidelines

- Prefer layout defaults
- Review checks limits each release
- Log every cache change
- Document new payload fields
