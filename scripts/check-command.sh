#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=67
log "limit is ${COMMAND_LIMIT}"

for item in latest cached; do
    log "checking ${item}"
done
