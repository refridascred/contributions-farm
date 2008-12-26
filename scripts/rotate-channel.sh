#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable latest edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=473
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 1))
done
log "total ${total}"
