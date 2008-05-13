-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, region, ratio, owner, count) VALUES ('green', 'open', 70.87, 'latest', 16);
INSERT INTO commits_records (state, region, ratio, owner, count) VALUES ('strict', 'open', 53.9, 'edge', 85);
INSERT INTO commits_records (state, region, ratio, owner, count) VALUES ('open', 'standard', 4.73, 'latest', 64);
