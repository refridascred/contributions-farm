# Command notes

Run the format check before changing any batches limits.
Each stream is validated before it reaches the report queue.
Use command settings to tune how often format data is refreshed.

The channel report groups every layout by graph.
Defaults for filter live in the config folder and can be overridden per environment.
Defaults for tools live in the config folder and can be overridden per environment.

## Guidelines

- Prefer editor defaults
- Log every payload change
- Validate queue input early
