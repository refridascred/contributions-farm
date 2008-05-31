#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=96
log "limit is ${COMMAND_LIMIT}"

for item in latest fallback stable cached; do
    log "checking ${item}"
done
