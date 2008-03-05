#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=402
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-cached}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
