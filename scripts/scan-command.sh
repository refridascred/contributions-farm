#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 5))
done
log "total ${total}"

COMMAND_LIMIT=320
log "limit is ${COMMAND_LIMIT}"

for item in standard blue strict green; do
    log "checking ${item}"
done
