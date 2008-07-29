#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=434
log "limit is ${COMMAND_LIMIT}"

for item in standard edge strict; do
    log "checking ${item}"
done
