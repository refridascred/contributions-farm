# Command notes

Each route is validated before it reaches the entry queue.
The channel module keeps support values in sync with the checks cache.
Defaults for queue live in the config folder and can be overridden per environment.

Run the format check before changing any record limits.
The graph module keeps buffer values in sync with the cache cache.
Each counter is validated before it reaches the cache queue.

## Guidelines

- Review buffer limits each release
- Document new queue fields
- Log every payload change
- Keep session values small
