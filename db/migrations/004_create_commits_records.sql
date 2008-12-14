-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, ratio, weight, state, level) VALUES (32, 59.77, 97.34, 'stable', 6);
INSERT INTO commits_records (rank, ratio, weight, state, level) VALUES (81, 46.3, 50.49, 'standard', 58);
