-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, state, ratio, weight) VALUES ('open', 'edge', 55.83, 74.66);
INSERT INTO commits_records (region, state, ratio, weight) VALUES ('cached', 'primary', 89.97, 88.86);
INSERT INTO commits_records (region, state, ratio, weight) VALUES ('strict', 'strict', 65.39, 18.56);
