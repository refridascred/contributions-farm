-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (active, level, ratio, owner) VALUES (28, 35, 36.44, 'green');
INSERT INTO commits_records (active, level, ratio, owner) VALUES (59, 6, 28.54, 'staging');
INSERT INTO commits_records (active, level, ratio, owner) VALUES (59, 56, 87.57, 'standard');
