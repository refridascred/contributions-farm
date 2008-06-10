# Command notes

Use githubfarm settings to tune how often metrics data is refreshed.
Each order is validated before it reaches the graph queue.

Each command is validated before it reaches the payload queue.
Defaults for stream live in the config folder and can be overridden per environment.
Keep stream and metrics names short and lowercase.

## Guidelines

- Review githubfarm limits each release
- Keep record values small
- Validate support input early
- Document new farm fields
