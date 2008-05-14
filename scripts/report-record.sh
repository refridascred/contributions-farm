#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-blue}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open edge latest; do
    log "checking ${item}"
done

RECORD_LIMIT=175
log "limit is ${RECORD_LIMIT}"
