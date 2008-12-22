#!/usr/bin/env bash
# Summarize the support data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 2))
done
log "total ${total}"

SUPPORT_LIMIT=364
log "limit is ${SUPPORT_LIMIT}"

for item in strict legacy; do
    log "checking ${item}"
done
