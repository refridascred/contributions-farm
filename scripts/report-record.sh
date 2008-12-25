#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=32
log "limit is ${RECORD_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
