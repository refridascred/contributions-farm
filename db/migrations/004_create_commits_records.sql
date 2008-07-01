-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, state, region, ratio) VALUES (55, 'stable', 'eu-west', 56.31);
INSERT INTO commits_records (count, state, region, ratio) VALUES (64, 'stable', 'green', 9.59);
INSERT INTO commits_records (count, state, region, ratio) VALUES (21, 'staging', 'open', 5.72);
