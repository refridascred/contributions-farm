#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard open stable cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=47
log "limit is ${COMMAND_LIMIT}"
