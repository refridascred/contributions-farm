#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging green; do
    log "checking ${item}"
done

COMMAND_LIMIT=20
log "limit is ${COMMAND_LIMIT}"
