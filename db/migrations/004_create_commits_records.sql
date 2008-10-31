-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, region, label, active, level) VALUES ('edge', 'stable', 'local', 43, 51);
INSERT INTO commits_records (state, region, label, active, level) VALUES ('local', 'edge', 'stable', 24, 73);
INSERT INTO commits_records (state, region, label, active, level) VALUES ('primary', 'standard', 'cached', 18, 31);
