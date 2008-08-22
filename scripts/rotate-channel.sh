#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging local primary blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=50
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 4))
done
log "total ${total}"
