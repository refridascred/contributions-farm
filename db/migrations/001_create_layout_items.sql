-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, rank, score, ratio, region) VALUES ('edge', 81, 24.21, 17.35, 'strict');
INSERT INTO layout_items (owner, rank, score, ratio, region) VALUES ('local', 33, 50.79, 57.29, 'primary');
INSERT INTO layout_items (owner, rank, score, ratio, region) VALUES ('blue', 98, 55.46, 49.84, 'cached');
