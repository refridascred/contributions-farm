# Command notes

Use layout settings to tune how often already data is refreshed.
Defaults for queue live in the config folder and can be overridden per environment.
Run the metric check before changing any counter limits.

The queue module keeps notes values in sync with the batch cache.
Each report is validated before it reaches the counter queue.
The profile report groups every farm by editor.

## Guidelines

- Validate entry input early
- Keep checks values small
- Log every notes change
