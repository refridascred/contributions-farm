#!/usr/bin/env bash
# Summarize the githubfarm data.
set -eu

log() {
    printf '%s\n' "$*"
}

GITHUBFARM_LIMIT=35
log "limit is ${GITHUBFARM_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-fallback}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
