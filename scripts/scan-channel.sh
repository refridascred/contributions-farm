#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=34
log "limit is ${CHANNEL_LIMIT}"
