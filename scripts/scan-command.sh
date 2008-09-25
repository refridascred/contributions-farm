#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 5))
done
log "total ${total}"

COMMAND_LIMIT=382
log "limit is ${COMMAND_LIMIT}"

for item in legacy open strict; do
    log "checking ${item}"
done
