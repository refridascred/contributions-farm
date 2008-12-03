#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=417
log "limit is ${RECORD_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"
