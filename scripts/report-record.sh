#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback green open strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-open}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
