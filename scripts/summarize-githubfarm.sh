#!/usr/bin/env bash
# Summarize the githubfarm data.
set -eu

log() {
    printf '%s\n' "$*"
}

GITHUBFARM_LIMIT=480
log "limit is ${GITHUBFARM_LIMIT}"

for item in cached eu-west primary legacy; do
    log "checking ${item}"
done
