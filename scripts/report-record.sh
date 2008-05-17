#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open strict blue; do
    log "checking ${item}"
done

mode="${1:-fallback}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 11); do
    total=$((total + i * 1))
done
log "total ${total}"
