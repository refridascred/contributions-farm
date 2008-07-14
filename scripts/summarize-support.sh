#!/usr/bin/env bash
# Summarize the support data.
set -eu

log() {
    printf '%s\n' "$*"
}

SUPPORT_LIMIT=141
log "limit is ${SUPPORT_LIMIT}"

for item in latest primary; do
    log "checking ${item}"
done
