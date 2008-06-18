-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, weight, rank, state, ratio) VALUES ('staging', 59.3, 18, 'edge', 24.21);
INSERT INTO stats_logs (token, weight, rank, state, ratio) VALUES ('cached', 53.86, 82, 'strict', 20.87);
