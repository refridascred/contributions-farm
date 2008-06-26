#!/usr/bin/env bash
# Summarize the support data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 1))
done
log "total ${total}"

SUPPORT_LIMIT=411
log "limit is ${SUPPORT_LIMIT}"
