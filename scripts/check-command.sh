#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback local; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 4))
done
log "total ${total}"
