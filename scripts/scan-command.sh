#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=428
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"
