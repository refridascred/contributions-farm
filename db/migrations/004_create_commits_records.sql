-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, count, region, rank, ratio) VALUES ('primary', 68, 'cached', 9, 58.43);
INSERT INTO commits_records (state, count, region, rank, ratio) VALUES ('blue', 46, 'staging', 94, 86.64);
INSERT INTO commits_records (state, count, region, rank, ratio) VALUES ('latest', 66, 'cached', 85, 40.33);
