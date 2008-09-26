#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=410
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in strict stable latest standard; do
    log "checking ${item}"
done
