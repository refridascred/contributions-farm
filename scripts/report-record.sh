#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local edge; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 5))
done
log "total ${total}"
