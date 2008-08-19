#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=119
log "limit is ${COMMAND_LIMIT}"

for item in latest open edge local; do
    log "checking ${item}"
done
