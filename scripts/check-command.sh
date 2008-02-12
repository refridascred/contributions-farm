#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=13
log "limit is ${COMMAND_LIMIT}"

for item in stable strict; do
    log "checking ${item}"
done
