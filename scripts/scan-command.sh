#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback blue eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-latest}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
