#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=259
log "limit is ${COMMAND_LIMIT}"

for item in local edge; do
    log "checking ${item}"
done
