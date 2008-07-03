#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in primary eu-west strict; do
    log "checking ${item}"
done
