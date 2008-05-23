# Command notes

Each cluster is validated before it reaches the buffer queue.
The cluster module keeps command values in sync with the notes cache.
The profile helpers are pure functions, so they are safe to call from any thread.

Keep notes and format names short and lowercase.
Defaults for queue live in the config folder and can be overridden per environment.

## Guidelines

- Log every report change
- Prefer order defaults
- Document new cache fields
