#!/usr/bin/env bash
# Summarize the githubfarm data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in strict legacy open; do
    log "checking ${item}"
done

GITHUBFARM_LIMIT=104
log "limit is ${GITHUBFARM_LIMIT}"
