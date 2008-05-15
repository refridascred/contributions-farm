#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge legacy; do
    log "checking ${item}"
done

CHANNEL_LIMIT=223
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"
