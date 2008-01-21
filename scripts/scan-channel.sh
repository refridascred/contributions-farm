#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=276
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-legacy}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
