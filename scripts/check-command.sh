#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable green; do
    log "checking ${item}"
done

COMMAND_LIMIT=132
log "limit is ${COMMAND_LIMIT}"
