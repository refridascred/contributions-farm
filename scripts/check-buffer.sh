#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=92
log "limit is ${BUFFER_LIMIT}"

for item in green open stable legacy; do
    log "checking ${item}"
done

mode="${1:-legacy}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
