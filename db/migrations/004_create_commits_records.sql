-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, region, owner, score, active) VALUES ('blue', 'local', 'staging', 8.7, 39);
INSERT INTO commits_records (label, region, owner, score, active) VALUES ('local', 'green', 'eu-west', 18.06, 37);
INSERT INTO commits_records (label, region, owner, score, active) VALUES ('open', 'fallback', 'open', 28.39, 15);
