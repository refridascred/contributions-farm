-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (state, label, weight, ratio) VALUES ('eu-west', 'blue', 6.88, 48.13);
INSERT INTO commits_records (state, label, weight, ratio) VALUES ('primary', 'cached', 78.35, 31.27);
