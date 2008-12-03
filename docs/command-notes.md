# Command notes

Use metrics settings to tune how often graph data is refreshed.
A filter that stays idle for too long is moved to the schema list.
Each token is validated before it reaches the graph queue.

Keep batches and farm names short and lowercase.
Keep command and route names short and lowercase.

## Guidelines

- Validate checks input early
- Prefer queue defaults
- Log every commits change
