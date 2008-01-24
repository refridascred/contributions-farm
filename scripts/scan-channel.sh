#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=159
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"
