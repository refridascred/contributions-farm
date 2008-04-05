#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local primary staging cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=146
log "limit is ${COMMAND_LIMIT}"
