# Command notes

Defaults for layout live in the config folder and can be overridden per environment.
Each layout is validated before it reaches the filter queue.
Run the buffer check before changing any entry limits.

The channel module keeps support values in sync with the batches cache.
Run the notes check before changing any context limits.

## Guidelines

- Prefer schema defaults
- Log every channel change
- Validate stream input early
