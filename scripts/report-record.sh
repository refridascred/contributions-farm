#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached latest primary; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-edge}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
