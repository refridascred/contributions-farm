-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, region, ratio, active, state) VALUES ('standard', 'eu-west', 22.27, 52, 'fallback');
INSERT INTO commits_records (owner, region, ratio, active, state) VALUES ('blue', 'fallback', 23.41, 0, 'strict');
