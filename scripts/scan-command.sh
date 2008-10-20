#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable green staging primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=132
log "limit is ${COMMAND_LIMIT}"
