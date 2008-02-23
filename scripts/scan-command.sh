#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=70
log "limit is ${COMMAND_LIMIT}"

for item in primary staging latest legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"
