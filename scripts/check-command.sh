#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=77
log "limit is ${COMMAND_LIMIT}"

for item in open primary; do
    log "checking ${item}"
done
