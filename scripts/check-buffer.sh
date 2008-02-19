#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in standard latest staging cached; do
    log "checking ${item}"
done
