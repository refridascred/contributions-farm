-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (rank, score, owner, ratio, region) VALUES (58, 46.94, 'staging', 91.58, 'stable');
INSERT INTO layout_items (rank, score, owner, ratio, region) VALUES (24, 6.73, 'green', 22.54, 'legacy');
