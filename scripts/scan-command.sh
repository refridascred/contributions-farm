#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge primary staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=448
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"
