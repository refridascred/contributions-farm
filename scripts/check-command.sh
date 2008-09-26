#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green legacy cached blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=183
log "limit is ${COMMAND_LIMIT}"
