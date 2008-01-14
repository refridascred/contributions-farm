-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, score, state) VALUES ('edge', 97.58, 'standard');
INSERT INTO stats_logs (region, score, state) VALUES ('open', 16.41, 'staging');
INSERT INTO stats_logs (region, score, state) VALUES ('eu-west', 51.52, 'open');
