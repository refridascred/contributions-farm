#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west latest stable strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=99
log "limit is ${COMMAND_LIMIT}"
