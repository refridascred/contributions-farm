#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 5))
done
log "total ${total}"

CHANNEL_LIMIT=120
log "limit is ${CHANNEL_LIMIT}"

for item in primary eu-west edge stable; do
    log "checking ${item}"
done
