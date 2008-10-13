#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable legacy standard; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-strict}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
