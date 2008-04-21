#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy eu-west cached open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-eu-west}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
