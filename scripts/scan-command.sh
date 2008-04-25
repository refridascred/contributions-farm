#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in primary legacy green standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=400
log "limit is ${COMMAND_LIMIT}"
