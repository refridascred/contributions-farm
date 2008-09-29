-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, count, weight, state, ratio) VALUES ('standard', 89, 52.21, 'fallback', 87.32);
INSERT INTO stats_logs (owner, count, weight, state, ratio) VALUES ('blue', 4, 11.93, 'local', 75.84);
