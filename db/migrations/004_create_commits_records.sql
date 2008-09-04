-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, ratio, owner, state) VALUES (95.79, 83.37, 'stable', 'standard');
