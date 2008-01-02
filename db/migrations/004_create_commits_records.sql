-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, ratio, level, token) VALUES ('stable', 33.21, 18, 'standard');
INSERT INTO commits_records (owner, ratio, level, token) VALUES ('stable', 90.62, 80, 'open');
