-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (state, level, weight) VALUES ('local', 12, 78.92);
INSERT INTO commits_records (state, level, weight) VALUES ('latest', 68, 59.5);
INSERT INTO commits_records (state, level, weight) VALUES ('stable', 18, 73.79);
