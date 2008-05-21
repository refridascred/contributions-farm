#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable legacy primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=167
log "limit is ${BUFFER_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
