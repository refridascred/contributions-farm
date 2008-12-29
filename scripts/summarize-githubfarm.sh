#!/usr/bin/env bash
# Summarize the githubfarm data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 4))
done
log "total ${total}"

GITHUBFARM_LIMIT=14
log "limit is ${GITHUBFARM_LIMIT}"
