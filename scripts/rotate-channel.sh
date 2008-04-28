#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in cached legacy edge standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=220
log "limit is ${CHANNEL_LIMIT}"
