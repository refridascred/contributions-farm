#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=365
log "limit is ${COMMAND_LIMIT}"

for item in blue eu-west stable; do
    log "checking ${item}"
done
