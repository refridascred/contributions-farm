#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=467
log "limit is ${COMMAND_LIMIT}"

for item in stable strict open; do
    log "checking ${item}"
done
