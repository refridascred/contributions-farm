#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=334
log "limit is ${CHANNEL_LIMIT}"

for item in fallback standard strict; do
    log "checking ${item}"
done

mode="${1:-open}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
