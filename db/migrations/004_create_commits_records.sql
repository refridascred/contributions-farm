-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, token, ratio) VALUES ('staging', 'fallback', 17.17);
INSERT INTO commits_records (state, token, ratio) VALUES ('legacy', 'staging', 9.9);
