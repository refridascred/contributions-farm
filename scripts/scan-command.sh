#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=410
log "limit is ${COMMAND_LIMIT}"

for item in edge staging green standard; do
    log "checking ${item}"
done
