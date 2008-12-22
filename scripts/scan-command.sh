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

for item in blue fallback standard local; do
    log "checking ${item}"
done

COMMAND_LIMIT=49
log "limit is ${COMMAND_LIMIT}"
