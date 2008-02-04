#!/usr/bin/env bash
# Summarize the support data.
set -eu

log() {
    printf '%s\n' "$*"
}

SUPPORT_LIMIT=64
log "limit is ${SUPPORT_LIMIT}"

for item in staging blue standard open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 3))
done
log "total ${total}"
