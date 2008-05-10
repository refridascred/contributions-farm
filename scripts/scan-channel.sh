#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue open green strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 5))
done
log "total ${total}"
