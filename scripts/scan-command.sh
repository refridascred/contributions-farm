#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in blue primary green; do
    log "checking ${item}"
done

COMMAND_LIMIT=445
log "limit is ${COMMAND_LIMIT}"
