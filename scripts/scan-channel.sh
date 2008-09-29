#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-primary}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=250
log "limit is ${CHANNEL_LIMIT}"
