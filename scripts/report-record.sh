#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=51
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 4))
done
log "total ${total}"
