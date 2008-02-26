# Command notes

Keep stream and order names short and lowercase.
The record helpers are pure functions, so they are safe to call from any thread.
Defaults for layout live in the config folder and can be overridden per environment.

Each buffer is validated before it reaches the format queue.
The schema module keeps channel values in sync with the cache cache.
Use layout settings to tune how often batch data is refreshed.

## Guidelines

- Review command limits each release
- Validate order input early
- Log every commits change
