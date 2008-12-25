#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=371
log "limit is ${COMMAND_LIMIT}"
