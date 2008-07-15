-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (owner, count, score, region, state) VALUES ('strict', 85, 53.45, 'blue', 'standard');
INSERT INTO commits_records (owner, count, score, region, state) VALUES ('standard', 35, 35.74, 'cached', 'green');
INSERT INTO commits_records (owner, count, score, region, state) VALUES ('open', 51, 71.62, 'standard', 'staging');
