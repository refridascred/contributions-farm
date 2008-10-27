#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict staging latest local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=471
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 2))
done
log "total ${total}"
