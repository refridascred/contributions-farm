-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (weight, token, state) VALUES (28.57, 'staging', 'stable');
INSERT INTO commits_records (weight, token, state) VALUES (17.32, 'standard', 'standard');
INSERT INTO commits_records (weight, token, state) VALUES (54.98, 'standard', 'primary');
