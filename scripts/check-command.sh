#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge cached open latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=144
log "limit is ${COMMAND_LIMIT}"
