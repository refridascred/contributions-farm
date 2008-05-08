-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, state, weight) VALUES (29, 'staging', 54.52);
INSERT INTO stats_logs (count, state, weight) VALUES (19, 'green', 17.56);
INSERT INTO stats_logs (count, state, weight) VALUES (9, 'local', 14.0);
