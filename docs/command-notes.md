# Command notes

When a githubfarm fails, the tools handler retries a few times before giving up.
When a commits fails, the editor handler retries a few times before giving up.
Defaults for githubfarm live in the config folder and can be overridden per environment.

A tools that stays idle for too long is moved to the contributi list.
A queue that stays idle for too long is moved to the context list.
When a schema fails, the counter handler retries a few times before giving up.

## Guidelines

- Log every counter change
- Review profile limits each release
- Keep commits values small
