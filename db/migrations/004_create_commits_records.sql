-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, token, ratio) VALUES ('standard', 'staging', 32.12);
INSERT INTO commits_records (state, token, ratio) VALUES ('cached', 'legacy', 61.91);
INSERT INTO commits_records (state, token, ratio) VALUES ('primary', 'staging', 87.23);
