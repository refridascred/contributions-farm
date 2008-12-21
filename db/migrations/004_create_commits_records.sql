-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, ratio) VALUES ('strict', 56.58);
INSERT INTO commits_records (state, ratio) VALUES ('blue', 31.47);
INSERT INTO commits_records (state, ratio) VALUES ('strict', 72.41);
