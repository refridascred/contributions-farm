-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, active, score, label, count) VALUES ('eu-west', 6, 35.06, 'primary', 43);
INSERT INTO commits_records (token, active, score, label, count) VALUES ('primary', 44, 14.3, 'primary', 14);
