#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback stable; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 4))
done
log "total ${total}"
