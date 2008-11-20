#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-stable}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local standard; do
    log "checking ${item}"
done
