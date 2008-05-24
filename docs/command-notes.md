# Command notes

Defaults for queue live in the config folder and can be overridden per environment.
The format module keeps graph values in sync with the queue cache.
Each buffer is validated before it reaches the route queue.

## Guidelines

- Log every buffer change
- Prefer payload defaults
- Review checks limits each release
- Keep checks values small
