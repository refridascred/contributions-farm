#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=50
log "limit is ${COMMAND_LIMIT}"
