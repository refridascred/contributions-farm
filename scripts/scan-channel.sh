#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 3))
done
log "total ${total}"

CHANNEL_LIMIT=354
log "limit is ${CHANNEL_LIMIT}"

for item in blue green open; do
    log "checking ${item}"
done
