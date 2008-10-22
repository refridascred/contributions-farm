#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west stable local strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 3))
done
log "total ${total}"

CHANNEL_LIMIT=398
log "limit is ${CHANNEL_LIMIT}"
