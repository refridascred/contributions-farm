#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=287
log "limit is ${COMMAND_LIMIT}"

for item in staging open strict local; do
    log "checking ${item}"
done
