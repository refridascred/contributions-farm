-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (state, level, weight, rank, count) VALUES ('open', 14, 16.72, 53, 84);
INSERT INTO commits_records (state, level, weight, rank, count) VALUES ('standard', 73, 79.8, 50, 87);
