-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, owner, token, active) VALUES (69, 'staging', 'latest', 81);
INSERT INTO commits_records (level, owner, token, active) VALUES (98, 'stable', 'eu-west', 79);
INSERT INTO commits_records (level, owner, token, active) VALUES (91, 'edge', 'staging', 21);
