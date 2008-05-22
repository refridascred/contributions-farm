# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
The session module keeps metrics values in sync with the graph cache.

Run the order check before changing any batches limits.
Defaults for cluster live in the config folder and can be overridden per environment.
Each layout is validated before it reaches the account queue.

## Guidelines

- Keep order values small
- Review batch limits each release
- Document new format fields
