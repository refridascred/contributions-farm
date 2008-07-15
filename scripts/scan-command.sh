#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in eu-west legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=401
log "limit is ${COMMAND_LIMIT}"
