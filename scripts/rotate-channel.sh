#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in green latest eu-west fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=254
log "limit is ${CHANNEL_LIMIT}"
