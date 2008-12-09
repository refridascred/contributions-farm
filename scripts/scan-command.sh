#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in fallback local stable open; do
    log "checking ${item}"
done

COMMAND_LIMIT=30
log "limit is ${COMMAND_LIMIT}"
