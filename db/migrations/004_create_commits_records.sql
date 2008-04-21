-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, weight, label, owner) VALUES ('open', 62.31, 'edge', 'edge');
INSERT INTO commits_records (state, weight, label, owner) VALUES ('primary', 3.79, 'standard', 'green');
INSERT INTO commits_records (state, weight, label, owner) VALUES ('strict', 47.15, 'green', 'eu-west');
