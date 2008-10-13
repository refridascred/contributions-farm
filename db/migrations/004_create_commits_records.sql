-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (score, owner, active, ratio) VALUES (16.42, 'cached', 24, 28.55);
INSERT INTO commits_records (score, owner, active, ratio) VALUES (50.5, 'green', 55, 82.15);
INSERT INTO commits_records (score, owner, active, ratio) VALUES (67.88, 'cached', 88, 58.33);
