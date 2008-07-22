#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue local cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=12
log "limit is ${COMMAND_LIMIT}"
