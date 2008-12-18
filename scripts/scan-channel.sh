#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in staging fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=88
log "limit is ${CHANNEL_LIMIT}"
