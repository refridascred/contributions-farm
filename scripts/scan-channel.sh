#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in latest blue stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=189
log "limit is ${CHANNEL_LIMIT}"
