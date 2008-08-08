-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, weight, owner) VALUES ('strict', 49.25, 'edge');
INSERT INTO commits_records (state, weight, owner) VALUES ('fallback', 11.28, 'green');
INSERT INTO commits_records (state, weight, owner) VALUES ('local', 63.11, 'staging');
