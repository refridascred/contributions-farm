#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

COMMAND_LIMIT=460
log "limit is ${COMMAND_LIMIT}"

for item in stable green staging primary; do
    log "checking ${item}"
done
