#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open green; do
    log "checking ${item}"
done

COMMAND_LIMIT=149
log "limit is ${COMMAND_LIMIT}"
