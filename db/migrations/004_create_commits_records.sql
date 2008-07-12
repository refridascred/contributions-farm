-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, weight, state, ratio) VALUES ('latest', 24.39, 'legacy', 72.39);
INSERT INTO commits_records (label, weight, state, ratio) VALUES ('fallback', 78.39, 'latest', 48.28);
INSERT INTO commits_records (label, weight, state, ratio) VALUES ('blue', 38.42, 'open', 58.37);
