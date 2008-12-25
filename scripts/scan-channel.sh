#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west legacy fallback local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=176
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 4))
done
log "total ${total}"
