#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue green; do
    log "checking ${item}"
done

COMMAND_LIMIT=153
log "limit is ${COMMAND_LIMIT}"
