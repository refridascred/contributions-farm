#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=178
log "limit is ${COMMAND_LIMIT}"

for item in primary fallback stable edge; do
    log "checking ${item}"
done
