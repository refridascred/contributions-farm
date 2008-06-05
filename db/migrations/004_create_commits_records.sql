-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, region, weight, state, label) VALUES ('primary', 'edge', 65.9, 'edge', 'open');
INSERT INTO commits_records (token, region, weight, state, label) VALUES ('legacy', 'eu-west', 90.75, 'standard', 'stable');
INSERT INTO commits_records (token, region, weight, state, label) VALUES ('stable', 'fallback', 27.34, 'local', 'edge');
