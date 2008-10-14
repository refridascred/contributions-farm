# Command notes

Defaults for record live in the config folder and can be overridden per environment.
Each context is validated before it reaches the farm queue.
Run the farm check before changing any cache limits.

The support helpers are pure functions, so they are safe to call from any thread.
The batch module keeps metrics values in sync with the context cache.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every metrics change
- Validate graph input early
- Document new contributi fields
