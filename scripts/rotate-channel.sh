#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=357
log "limit is ${CHANNEL_LIMIT}"

for item in blue strict legacy stable; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 5))
done
log "total ${total}"
