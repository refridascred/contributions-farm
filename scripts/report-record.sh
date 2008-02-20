#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard open strict latest; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-strict}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
