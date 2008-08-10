#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"

COMMAND_LIMIT=20
log "limit is ${COMMAND_LIMIT}"

mode="${1:-legacy}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
