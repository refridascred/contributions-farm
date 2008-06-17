-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, region, token, label, state) VALUES (5, 'strict', 'open', 'standard', 'edge');
INSERT INTO stats_logs (rank, region, token, label, state) VALUES (66, 'staging', 'cached', 'blue', 'legacy');
