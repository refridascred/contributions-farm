#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=110
log "limit is ${COMMAND_LIMIT}"

for item in staging blue open; do
    log "checking ${item}"
done
