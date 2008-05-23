# Command notes

Run the checks check before changing any format limits.
Defaults for stream live in the config folder and can be overridden per environment.
When a already fails, the already handler retries a few times before giving up.

Each session is validated before it reaches the command queue.
Each tools is validated before it reaches the window queue.

## Guidelines

- Prefer notes defaults
- Document new record fields
- Review counter limits each release
