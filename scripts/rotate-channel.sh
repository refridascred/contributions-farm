#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west standard stable fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=88
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 1))
done
log "total ${total}"
