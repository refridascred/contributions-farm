#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest staging stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=187
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-fallback}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
