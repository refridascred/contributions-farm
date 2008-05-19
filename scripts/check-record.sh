#!/usr/bin/env bash
# Check the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary open legacy; do
    log "checking ${item}"
done

RECORD_LIMIT=198
log "limit is ${RECORD_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
