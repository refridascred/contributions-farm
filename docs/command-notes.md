# Command notes

Keep support and route names short and lowercase.
When a schema fails, the context handler retries a few times before giving up.
Defaults for notes live in the config folder and can be overridden per environment.

Each commits is validated before it reaches the command queue.
Use order settings to tune how often window data is refreshed.

## Guidelines

- Log every filter change
- Review payload limits each release
- Document new already fields
