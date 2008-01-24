#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=495
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-eu-west}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
