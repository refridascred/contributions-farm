#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached standard fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=163
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 5))
done
log "total ${total}"
