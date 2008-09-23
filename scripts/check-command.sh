#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=476
log "limit is ${COMMAND_LIMIT}"

for item in open latest local; do
    log "checking ${item}"
done
