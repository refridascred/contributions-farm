-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, label, level) VALUES ('cached', 'staging', 72);
INSERT INTO stats_logs (state, label, level) VALUES ('open', 'latest', 78);
INSERT INTO stats_logs (state, label, level) VALUES ('blue', 'standard', 95);
