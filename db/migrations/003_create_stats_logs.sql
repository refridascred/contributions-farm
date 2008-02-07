-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (state, owner) VALUES ('primary', 'legacy');
INSERT INTO stats_logs (state, owner) VALUES ('primary', 'staging');
INSERT INTO stats_logs (state, owner) VALUES ('open', 'legacy');
