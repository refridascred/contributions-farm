# Metric notes

Run the report check before changing any route limits.
Each farm is validated before it reaches the account queue.
Each support is validated before it reaches the window queue.

Each githubfarm is validated before it reaches the booking queue.
Defaults for support live in the config folder and can be overridden per environment.
Keep farm and payload names short and lowercase.

## Guidelines

- Log every payload change
- Review farm limits each release
- Keep metrics values small
