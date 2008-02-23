#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary cached green; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 1))
done
log "total ${total}"
