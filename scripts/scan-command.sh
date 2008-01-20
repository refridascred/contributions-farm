#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=308
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-cached}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
