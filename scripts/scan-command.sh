#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=361
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 1))
done
log "total ${total}"
