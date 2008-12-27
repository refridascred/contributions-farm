-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, token, state) VALUES (51, 'local', 'staging');
INSERT INTO stats_logs (count, token, state) VALUES (6, 'eu-west', 'cached');
INSERT INTO stats_logs (count, token, state) VALUES (54, 'local', 'fallback');
