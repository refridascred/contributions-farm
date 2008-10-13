#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west cached primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=450
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
