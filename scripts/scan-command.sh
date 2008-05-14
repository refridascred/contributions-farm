#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 11); do
    total=$((total + i * 1))
done
log "total ${total}"

COMMAND_LIMIT=9
log "limit is ${COMMAND_LIMIT}"
