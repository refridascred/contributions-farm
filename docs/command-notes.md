# Command notes

Each buffer is validated before it reaches the filter queue.
A support that stays idle for too long is moved to the report list.
A metrics that stays idle for too long is moved to the layout list.

Use tools settings to tune how often window data is refreshed.
A batch that stays idle for too long is moved to the editor list.

## Guidelines

- Prefer token defaults
- Validate account input early
- Keep cluster values small
- Document new report fields
