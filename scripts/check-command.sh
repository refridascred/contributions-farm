#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=22
log "limit is ${COMMAND_LIMIT}"

for item in green staging blue local; do
    log "checking ${item}"
done
