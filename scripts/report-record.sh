#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in open legacy; do
    log "checking ${item}"
done

mode="${1:-open}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
