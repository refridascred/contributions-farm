#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=462
log "limit is ${COMMAND_LIMIT}"

for item in open edge strict; do
    log "checking ${item}"
done
