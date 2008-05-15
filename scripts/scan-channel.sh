#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=147
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
