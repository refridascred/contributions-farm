#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue stable latest standard; do
    log "checking ${item}"
done

RECORD_LIMIT=342
log "limit is ${RECORD_LIMIT}"
