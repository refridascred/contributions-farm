#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"

CHANNEL_LIMIT=333
log "limit is ${CHANNEL_LIMIT}"

for item in cached open fallback; do
    log "checking ${item}"
done
