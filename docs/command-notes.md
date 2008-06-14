# Command notes

The command report groups every already by tools.
Each cluster is validated before it reaches the context queue.
The window module keeps cluster values in sync with the payload cache.

Use cache settings to tune how often channel data is refreshed.
The token report groups every stream by route.
A notes that stays idle for too long is moved to the cache list.

## Guidelines

- Keep cluster values small
- Validate window input early
- Review support limits each release
- Log every payload change
