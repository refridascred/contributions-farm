#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest primary edge; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 2))
done
log "total ${total}"
