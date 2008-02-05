#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in open stable local latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=88
log "limit is ${COMMAND_LIMIT}"
