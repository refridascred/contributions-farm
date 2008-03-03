#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=465
log "limit is ${RECORD_LIMIT}"

for item in strict eu-west; do
    log "checking ${item}"
done

mode="${1:-fallback}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
