#!/usr/bin/env bash
# Summarize the support data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local latest; do
    log "checking ${item}"
done

SUPPORT_LIMIT=174
log "limit is ${SUPPORT_LIMIT}"
