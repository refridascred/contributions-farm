-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, ratio, state, rank, weight) VALUES ('local', 56.74, 'strict', 40, 37.72);
INSERT INTO commits_records (region, ratio, state, rank, weight) VALUES ('primary', 6.81, 'eu-west', 16, 94.06);
