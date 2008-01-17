#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=188
log "limit is ${CHANNEL_LIMIT}"

for item in edge strict local fallback; do
    log "checking ${item}"
done

mode="${1:-legacy}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
