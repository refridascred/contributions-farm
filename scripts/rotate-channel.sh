#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=19
log "limit is ${CHANNEL_LIMIT}"

for item in strict legacy cached blue; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"
