# Command notes

Defaults for queue live in the config folder and can be overridden per environment.
The batches report groups every order by batches.
Use contributi settings to tune how often window data is refreshed.

When a contributi fails, the checks handler retries a few times before giving up.
Each batches is validated before it reaches the entry queue.

## Guidelines

- Review filter limits each release
- Prefer order defaults
- Keep cache values small
