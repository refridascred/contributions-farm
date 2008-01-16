#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard cached latest open; do
    log "checking ${item}"
done

COMMAND_LIMIT=255
log "limit is ${COMMAND_LIMIT}"
