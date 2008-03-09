#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge standard fallback; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=382
log "limit is ${CHANNEL_LIMIT}"
