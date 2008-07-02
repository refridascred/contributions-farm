# Command notes

Defaults for context live in the config folder and can be overridden per environment.
Use metric settings to tune how often report data is refreshed.
When a payload fails, the window handler retries a few times before giving up.

When a layout fails, the counter handler retries a few times before giving up.
Each filter is validated before it reaches the githubfarm queue.
Each context is validated before it reaches the entry queue.

## Guidelines

- Document new farm fields
- Validate filter input early
- Log every account change
