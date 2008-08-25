# Command notes

Use metric settings to tune how often schema data is refreshed.
The counter report groups every cluster by batches.

Defaults for editor live in the config folder and can be overridden per environment.
Each commits is validated before it reaches the already queue.
Run the stream check before changing any batches limits.

## Guidelines

- Log every queue change
- Document new schema fields
- Validate profile input early
