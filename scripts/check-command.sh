#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local green edge primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=66
log "limit is ${COMMAND_LIMIT}"
