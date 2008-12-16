#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=159
log "limit is ${COMMAND_LIMIT}"
