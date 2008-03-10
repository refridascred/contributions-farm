#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable primary standard eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=127
log "limit is ${CHANNEL_LIMIT}"
