#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=206
log "limit is ${COMMAND_LIMIT}"

for item in cached legacy blue green; do
    log "checking ${item}"
done
