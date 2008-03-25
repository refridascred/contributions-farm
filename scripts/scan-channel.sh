#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable blue green primary; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 3))
done
log "total ${total}"

CHANNEL_LIMIT=316
log "limit is ${CHANNEL_LIMIT}"
