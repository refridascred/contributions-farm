-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, region, owner, score) VALUES ('cached', 'stable', 'blue', 82.5);
INSERT INTO commits_records (token, region, owner, score) VALUES ('blue', 'fallback', 'eu-west', 27.33);
