#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in staging primary strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=472
log "limit is ${CHANNEL_LIMIT}"
