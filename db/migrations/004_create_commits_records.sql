-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (state, rank, count, region, level) VALUES ('eu-west', 11, 7, 'staging', 83);
INSERT INTO commits_records (state, rank, count, region, level) VALUES ('strict', 13, 5, 'cached', 2);
INSERT INTO commits_records (state, rank, count, region, level) VALUES ('eu-west', 14, 82, 'edge', 82);
