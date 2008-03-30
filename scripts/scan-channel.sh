#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green latest local; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=289
log "limit is ${CHANNEL_LIMIT}"
