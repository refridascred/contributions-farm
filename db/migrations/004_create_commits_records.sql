-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, label, weight, ratio, count) VALUES ('standard', 'local', 18.44, 60.95, 1);
INSERT INTO commits_records (state, label, weight, ratio, count) VALUES ('latest', 'green', 25.22, 49.79, 79);
INSERT INTO commits_records (state, label, weight, ratio, count) VALUES ('blue', 'primary', 50.68, 1.25, 80);
