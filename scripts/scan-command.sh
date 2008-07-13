#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=80
log "limit is ${COMMAND_LIMIT}"

for item in cached standard; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 2))
done
log "total ${total}"
