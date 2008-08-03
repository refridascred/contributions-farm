#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached green eu-west local; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"
