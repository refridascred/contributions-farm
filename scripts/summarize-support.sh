#!/usr/bin/env bash
# Summarize the support data.
set -eu

log() {
    printf '%s\n' "$*"
}

SUPPORT_LIMIT=92
log "limit is ${SUPPORT_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 5))
done
log "total ${total}"
