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

SUPPORT_LIMIT=482
log "limit is ${SUPPORT_LIMIT}"

for item in legacy blue local; do
    log "checking ${item}"
done
