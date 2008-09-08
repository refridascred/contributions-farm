#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue legacy local stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=252
log "limit is ${COMMAND_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
