#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=400
log "limit is ${COMMAND_LIMIT}"

for item in staging stable open primary; do
    log "checking ${item}"
done
