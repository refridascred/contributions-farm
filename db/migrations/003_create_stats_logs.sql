-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, owner, label) VALUES ('strict', 'legacy', 'fallback');
INSERT INTO stats_logs (region, owner, label) VALUES ('cached', 'local', 'latest');
