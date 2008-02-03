#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict edge staging cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=334
log "limit is ${COMMAND_LIMIT}"
