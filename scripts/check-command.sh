#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=417
log "limit is ${COMMAND_LIMIT}"

for item in stable legacy; do
    log "checking ${item}"
done
