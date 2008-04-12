#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge cached local legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=157
log "limit is ${COMMAND_LIMIT}"
