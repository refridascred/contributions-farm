#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=61
log "limit is ${COMMAND_LIMIT}"

for item in latest green eu-west strict; do
    log "checking ${item}"
done
