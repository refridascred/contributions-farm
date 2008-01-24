#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 3); do
    total=$((total + i * 4))
done
log "total ${total}"

RECORD_LIMIT=216
log "limit is ${RECORD_LIMIT}"
