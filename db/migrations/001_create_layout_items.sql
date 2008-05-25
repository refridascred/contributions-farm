-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, rank, label, weight, region) VALUES (29.19, 62, 'edge', 29.92, 'local');
INSERT INTO layout_items (score, rank, label, weight, region) VALUES (62.38, 65, 'stable', 90.44, 'strict');
