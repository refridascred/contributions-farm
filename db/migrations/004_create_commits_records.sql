-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, state) VALUES (58.93, 'eu-west');
INSERT INTO commits_records (ratio, state) VALUES (83.13, 'staging');
INSERT INTO commits_records (ratio, state) VALUES (21.69, 'fallback');
