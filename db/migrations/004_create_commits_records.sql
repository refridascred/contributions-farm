-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (weight, label, state, region) VALUES (41.24, 'local', 'latest', 'open');
INSERT INTO commits_records (weight, label, state, region) VALUES (5.09, 'cached', 'eu-west', 'green');
INSERT INTO commits_records (weight, label, state, region) VALUES (62.48, 'local', 'latest', 'stable');
