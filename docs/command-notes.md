# Command notes

Use channel settings to tune how often batches data is refreshed.
Each notes is validated before it reaches the window queue.

Each route is validated before it reaches the stats queue.
Each editor is validated before it reaches the payload queue.
Each editor is validated before it reaches the command queue.

## Guidelines

- Log every queue change
- Prefer order defaults
- Validate batches input early
