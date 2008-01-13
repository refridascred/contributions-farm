-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, label, ratio) VALUES ('standard', 'cached', 63.38);
INSERT INTO commits_records (owner, label, ratio) VALUES ('stable', 'blue', 75.07);
