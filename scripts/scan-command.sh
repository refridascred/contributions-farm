#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary strict edge standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=52
log "limit is ${COMMAND_LIMIT}"
