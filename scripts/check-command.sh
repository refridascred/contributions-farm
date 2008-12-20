#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=444
log "limit is ${COMMAND_LIMIT}"

for item in blue open standard strict; do
    log "checking ${item}"
done
