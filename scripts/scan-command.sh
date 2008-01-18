#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=409
log "limit is ${COMMAND_LIMIT}"

for item in eu-west strict standard; do
    log "checking ${item}"
done
