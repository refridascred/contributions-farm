# Command notes

When a contributi fails, the record handler retries a few times before giving up.
Keep session and entry names short and lowercase.

Use batches settings to tune how often tools data is refreshed.
Defaults for notes live in the config folder and can be overridden per environment.
Use checks settings to tune how often buffer data is refreshed.

## Guidelines

- Log every payload change
- Validate metrics input early
- Keep format values small
- Review channel limits each release
