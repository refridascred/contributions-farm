-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (state, rank, level, count, weight) VALUES ('stable', 82, 70, 82, 44.06);
INSERT INTO commits_records (state, rank, level, count, weight) VALUES ('strict', 23, 92, 3, 69.99);
