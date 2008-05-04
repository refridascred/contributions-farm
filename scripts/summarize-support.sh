#!/usr/bin/env bash
# Summarize the support data.
set -eu

log() {
    printf '%s\n' "$*"
}

SUPPORT_LIMIT=309
log "limit is ${SUPPORT_LIMIT}"

for item in standard open primary; do
    log "checking ${item}"
done
