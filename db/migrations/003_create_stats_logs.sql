-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, token, ratio, rank) VALUES ('open', 'green', 22.77, 49);
INSERT INTO stats_logs (state, token, ratio, rank) VALUES ('legacy', 'stable', 19.7, 22);
