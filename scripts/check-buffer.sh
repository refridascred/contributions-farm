#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard fallback stable; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 4))
done
log "total ${total}"
