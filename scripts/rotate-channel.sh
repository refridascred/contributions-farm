#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in primary eu-west stable legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=110
log "limit is ${CHANNEL_LIMIT}"
