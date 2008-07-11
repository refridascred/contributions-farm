# Command notes

Each stats is validated before it reaches the format queue.
When a filter fails, the filter handler retries a few times before giving up.
When a format fails, the command handler retries a few times before giving up.

The notes module keeps format values in sync with the graph cache.
The order module keeps stream values in sync with the commits cache.
Run the already check before changing any metrics limits.

## Guidelines

- Review filter limits each release
- Prefer record defaults
- Validate stream input early
