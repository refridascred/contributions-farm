#!/usr/bin/env bash
# Scan the channel data.
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

for item in fallback green eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=24
log "limit is ${CHANNEL_LIMIT}"
