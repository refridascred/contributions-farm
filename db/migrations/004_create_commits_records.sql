-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (score, region, count, owner, state) VALUES (22.09, 'eu-west', 50, 'cached', 'legacy');
INSERT INTO commits_records (score, region, count, owner, state) VALUES (29.96, 'cached', 76, 'eu-west', 'open');
