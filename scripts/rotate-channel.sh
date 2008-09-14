#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open edge eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"

CHANNEL_LIMIT=447
log "limit is ${CHANNEL_LIMIT}"
