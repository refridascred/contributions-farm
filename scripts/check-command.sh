#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=151
log "limit is ${COMMAND_LIMIT}"

for item in blue eu-west edge; do
    log "checking ${item}"
done
