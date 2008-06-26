# Command notes

Defaults for githubfarm live in the config folder and can be overridden per environment.
The entry module keeps counter values in sync with the queue cache.
The contributi helpers are pure functions, so they are safe to call from any thread.

The cache module keeps channel values in sync with the already cache.
Defaults for queue live in the config folder and can be overridden per environment.

## Guidelines

- Log every record change
- Keep entry values small
- Review cache limits each release
