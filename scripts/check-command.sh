#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=349
log "limit is ${COMMAND_LIMIT}"

for item in blue primary staging green; do
    log "checking ${item}"
done
