-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, token, level, owner) VALUES (99, 'eu-west', 59, 'green');
INSERT INTO commits_records (rank, token, level, owner) VALUES (43, 'fallback', 75, 'local');
INSERT INTO commits_records (rank, token, level, owner) VALUES (96, 'staging', 62, 'primary');
