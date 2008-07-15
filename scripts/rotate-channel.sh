#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary cached green; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 4))
done
log "total ${total}"
