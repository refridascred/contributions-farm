#!/usr/bin/env bash
# Summarize the support data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge eu-west legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-primary}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
