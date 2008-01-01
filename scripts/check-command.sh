#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict local standard edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=284
log "limit is ${COMMAND_LIMIT}"
