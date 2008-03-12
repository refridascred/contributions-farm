#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in cached blue open standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=186
log "limit is ${CHANNEL_LIMIT}"
