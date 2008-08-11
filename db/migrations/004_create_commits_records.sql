-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, score, active, level) VALUES ('legacy', 80.3, 63, 43);
INSERT INTO commits_records (token, score, active, level) VALUES ('edge', 64.42, 89, 25);
INSERT INTO commits_records (token, score, active, level) VALUES ('eu-west', 83.4, 87, 65);
