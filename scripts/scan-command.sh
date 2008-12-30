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

COMMAND_LIMIT=183
log "limit is ${COMMAND_LIMIT}"

for item in legacy local strict; do
    log "checking ${item}"
done
