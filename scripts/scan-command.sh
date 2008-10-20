#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=397
log "limit is ${COMMAND_LIMIT}"

for item in stable green open; do
    log "checking ${item}"
done
