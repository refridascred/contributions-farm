#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

COMMAND_LIMIT=208
log "limit is ${COMMAND_LIMIT}"

for item in stable cached green; do
    log "checking ${item}"
done
