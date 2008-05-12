#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge eu-west latest staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=23
log "limit is ${COMMAND_LIMIT}"
