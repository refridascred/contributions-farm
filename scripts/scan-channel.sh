#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in fallback eu-west primary; do
    log "checking ${item}"
done
