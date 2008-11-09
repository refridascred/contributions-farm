-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, count, rank, state, ratio) VALUES ('local', 83, 68, 'stable', 80.69);
INSERT INTO stats_logs (label, count, rank, state, ratio) VALUES ('blue', 20, 0, 'green', 52.45);
