#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=51
log "limit is ${COMMAND_LIMIT}"

for item in cached staging green fallback; do
    log "checking ${item}"
done
