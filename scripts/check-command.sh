#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue open standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=405
log "limit is ${COMMAND_LIMIT}"
