-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (region, count, state, owner, score) VALUES ('green', 77, 'staging', 'eu-west', 47.05);
INSERT INTO commits_records (region, count, state, owner, score) VALUES ('green', 0, 'open', 'eu-west', 51.59);
INSERT INTO commits_records (region, count, state, owner, score) VALUES ('green', 60, 'standard', 'eu-west', 66.93);
