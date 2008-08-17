#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 4))
done
log "total ${total}"

COMMAND_LIMIT=302
log "limit is ${COMMAND_LIMIT}"
