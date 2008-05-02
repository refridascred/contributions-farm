# Command notes

The notes module keeps layout values in sync with the layout cache.
The batch module keeps cache values in sync with the already cache.
Each command is validated before it reaches the editor queue.

## Guidelines

- Keep checks values small
- Validate channel input early
- Document new channel fields
- Log every graph change
