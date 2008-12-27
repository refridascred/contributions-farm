#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=188
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
