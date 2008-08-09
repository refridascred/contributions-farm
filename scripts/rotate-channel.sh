#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=155
log "limit is ${CHANNEL_LIMIT}"

for item in edge strict fallback latest; do
    log "checking ${item}"
done
