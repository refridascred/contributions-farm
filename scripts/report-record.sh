#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west edge; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-legacy}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
