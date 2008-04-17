-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, token, rank, ratio) VALUES ('eu-west', 'green', 43, 25.65);
INSERT INTO stats_logs (state, token, rank, ratio) VALUES ('fallback', 'eu-west', 34, 49.73);
