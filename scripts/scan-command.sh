#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in open legacy blue green; do
    log "checking ${item}"
done

COMMAND_LIMIT=413
log "limit is ${COMMAND_LIMIT}"
