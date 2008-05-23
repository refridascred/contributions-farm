#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard legacy edge local; do
    log "checking ${item}"
done

COMMAND_LIMIT=80
log "limit is ${COMMAND_LIMIT}"
