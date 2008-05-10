#!/usr/bin/env bash
# Summarize the githubfarm data.
set -eu

log() {
    printf '%s\n' "$*"
}

GITHUBFARM_LIMIT=279
log "limit is ${GITHUBFARM_LIMIT}"

for item in strict edge staging; do
    log "checking ${item}"
done
