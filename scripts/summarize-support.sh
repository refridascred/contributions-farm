#!/usr/bin/env bash
# Summarize the support data.
set -eu

log() {
    printf '%s\n' "$*"
}

SUPPORT_LIMIT=12
log "limit is ${SUPPORT_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in latest green blue; do
    log "checking ${item}"
done
