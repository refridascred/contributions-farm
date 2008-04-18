#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard strict local; do
    log "checking ${item}"
done

COMMAND_LIMIT=481
log "limit is ${COMMAND_LIMIT}"
