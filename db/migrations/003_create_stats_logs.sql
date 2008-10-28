-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, state, rank, ratio) VALUES ('staging', 'cached', 18, 55.07);
INSERT INTO stats_logs (token, state, rank, ratio) VALUES ('strict', 'standard', 96, 69.05);
INSERT INTO stats_logs (token, state, rank, ratio) VALUES ('strict', 'primary', 47, 58.98);
