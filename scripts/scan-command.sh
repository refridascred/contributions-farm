#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=299
log "limit is ${COMMAND_LIMIT}"

for item in open stable legacy edge; do
    log "checking ${item}"
done
