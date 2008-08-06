-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, count, ratio) VALUES ('legacy', 36, 62.47);
INSERT INTO commits_records (state, count, ratio) VALUES ('local', 33, 46.14);
INSERT INTO commits_records (state, count, ratio) VALUES ('legacy', 65, 86.8);
