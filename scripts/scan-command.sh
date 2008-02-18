#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=140
log "limit is ${COMMAND_LIMIT}"

for item in cached open; do
    log "checking ${item}"
done
