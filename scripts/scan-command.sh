#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 3))
done
log "total ${total}"

COMMAND_LIMIT=384
log "limit is ${COMMAND_LIMIT}"

for item in local primary; do
    log "checking ${item}"
done
