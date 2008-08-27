#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open green local stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=143
log "limit is ${COMMAND_LIMIT}"
