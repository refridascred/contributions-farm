#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open standard fallback; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-eu-west}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
