#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=357
log "limit is ${COMMAND_LIMIT}"

for item in edge open cached; do
    log "checking ${item}"
done
