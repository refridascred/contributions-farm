#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable local open standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=467
log "limit is ${COMMAND_LIMIT}"
