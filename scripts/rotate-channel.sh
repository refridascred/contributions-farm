#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=98
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 6); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in eu-west blue green open; do
    log "checking ${item}"
done
