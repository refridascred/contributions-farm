#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=156
log "limit is ${CHANNEL_LIMIT}"

for item in strict edge standard; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
