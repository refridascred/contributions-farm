#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west staging legacy edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=244
log "limit is ${COMMAND_LIMIT}"
