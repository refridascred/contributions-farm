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

CHANNEL_LIMIT=176
log "limit is ${CHANNEL_LIMIT}"

for item in legacy blue eu-west fallback; do
    log "checking ${item}"
done
