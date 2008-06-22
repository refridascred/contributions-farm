#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback legacy open edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=227
log "limit is ${COMMAND_LIMIT}"
