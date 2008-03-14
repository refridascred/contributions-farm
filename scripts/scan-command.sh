#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=78
log "limit is ${COMMAND_LIMIT}"

for item in primary strict eu-west; do
    log "checking ${item}"
done
