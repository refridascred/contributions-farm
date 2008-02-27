-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, level, active, rank) VALUES ('local', 92, 82, 24);
INSERT INTO commits_records (token, level, active, rank) VALUES ('legacy', 44, 50, 67);
INSERT INTO commits_records (token, level, active, rank) VALUES ('standard', 79, 26, 40);
