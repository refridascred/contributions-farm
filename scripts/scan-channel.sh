#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=473
log "limit is ${CHANNEL_LIMIT}"

for item in stable legacy cached green; do
    log "checking ${item}"
done
