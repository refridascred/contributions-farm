#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in stable open eu-west fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=320
log "limit is ${COMMAND_LIMIT}"
