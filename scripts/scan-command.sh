#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in green cached strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=449
log "limit is ${COMMAND_LIMIT}"
