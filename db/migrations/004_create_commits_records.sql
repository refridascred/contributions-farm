-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, level, owner, token) VALUES (27.91, 12, 'primary', 'stable');
INSERT INTO commits_records (ratio, level, owner, token) VALUES (55.34, 38, 'strict', 'legacy');
INSERT INTO commits_records (ratio, level, owner, token) VALUES (31.48, 42, 'green', 'eu-west');
