-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (state, ratio) VALUES ('edge', 73.86);
INSERT INTO commits_records (state, ratio) VALUES ('edge', 78.52);
INSERT INTO commits_records (state, ratio) VALUES ('blue', 84.35);
