#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable open strict primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=141
log "limit is ${CHANNEL_LIMIT}"
