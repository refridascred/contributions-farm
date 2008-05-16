#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue primary edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=117
log "limit is ${COMMAND_LIMIT}"
