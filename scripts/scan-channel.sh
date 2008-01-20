#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=201
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
