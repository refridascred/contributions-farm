#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in primary strict green edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=478
log "limit is ${CHANNEL_LIMIT}"
