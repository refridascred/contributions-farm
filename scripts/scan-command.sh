#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 4); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in latest primary legacy fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=75
log "limit is ${COMMAND_LIMIT}"
