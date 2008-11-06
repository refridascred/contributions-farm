-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, weight, state) VALUES ('fallback', 78.24, 'eu-west');
INSERT INTO commits_records (label, weight, state) VALUES ('standard', 55.33, 'fallback');
INSERT INTO commits_records (label, weight, state) VALUES ('strict', 35.31, 'edge');
