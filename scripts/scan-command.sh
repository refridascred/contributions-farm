#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard legacy green staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=463
log "limit is ${COMMAND_LIMIT}"
