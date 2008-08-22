#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=387
log "limit is ${COMMAND_LIMIT}"

for item in local standard blue primary; do
    log "checking ${item}"
done
