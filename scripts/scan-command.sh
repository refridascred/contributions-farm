#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=378
log "limit is ${COMMAND_LIMIT}"

for item in fallback legacy edge; do
    log "checking ${item}"
done
