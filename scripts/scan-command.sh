#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=65
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in stable staging standard strict; do
    log "checking ${item}"
done
