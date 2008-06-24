# Command notes

Each checks is validated before it reaches the farm queue.
Defaults for route live in the config folder and can be overridden per environment.

The buffer report groups every stream by batches.
Each window is validated before it reaches the window queue.
The context report groups every token by cluster.

## Guidelines

- Document new cluster fields
- Log every notes change
- Prefer cluster defaults
