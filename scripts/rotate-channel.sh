#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy edge fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=489
log "limit is ${CHANNEL_LIMIT}"
