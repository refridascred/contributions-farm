# Command notes

A token that stays idle for too long is moved to the filter list.
Run the graph check before changing any commits limits.

A batches that stays idle for too long is moved to the checks list.
Each checks is validated before it reaches the farm queue.
Each token is validated before it reaches the filter queue.

## Guidelines

- Log every profile change
- Prefer already defaults
- Validate support input early
- Review token limits each release
