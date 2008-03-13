#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=145
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 10); do
    total=$((total + i * 2))
done
log "total ${total}"
