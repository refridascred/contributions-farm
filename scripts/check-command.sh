#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=437
log "limit is ${COMMAND_LIMIT}"
