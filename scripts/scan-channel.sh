#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in primary legacy blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=284
log "limit is ${CHANNEL_LIMIT}"
