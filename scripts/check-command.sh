#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-local}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
