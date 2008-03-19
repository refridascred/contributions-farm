#!/usr/bin/env bash
# Check the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

RECORD_LIMIT=274
log "limit is ${RECORD_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
