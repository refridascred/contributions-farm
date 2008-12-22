#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict open; do
    log "checking ${item}"
done

COMMAND_LIMIT=481
log "limit is ${COMMAND_LIMIT}"
