#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=466
log "limit is ${COMMAND_LIMIT}"

for item in cached open latest; do
    log "checking ${item}"
done
