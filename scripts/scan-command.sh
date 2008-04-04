#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

COMMAND_LIMIT=120
log "limit is ${COMMAND_LIMIT}"

for item in local legacy edge; do
    log "checking ${item}"
done
