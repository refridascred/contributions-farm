#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict legacy blue local; do
    log "checking ${item}"
done

COMMAND_LIMIT=305
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
