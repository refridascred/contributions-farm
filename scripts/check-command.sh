#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=292
log "limit is ${COMMAND_LIMIT}"

for item in standard blue local; do
    log "checking ${item}"
done
