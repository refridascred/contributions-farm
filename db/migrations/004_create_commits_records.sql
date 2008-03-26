-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, state, level, region, weight) VALUES (22, 'standard', 56, 'strict', 88.42);
INSERT INTO commits_records (count, state, level, region, weight) VALUES (74, 'primary', 89, 'open', 38.79);
INSERT INTO commits_records (count, state, level, region, weight) VALUES (94, 'cached', 93, 'blue', 26.14);
