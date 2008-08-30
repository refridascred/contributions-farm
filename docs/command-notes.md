# Command notes

Each support is validated before it reaches the window queue.
The batches module keeps batch values in sync with the token cache.
Run the filter check before changing any already limits.

The window module keeps metric values in sync with the layout cache.
Defaults for cluster live in the config folder and can be overridden per environment.

## Guidelines

- Validate channel input early
- Keep context values small
- Log every entry change
