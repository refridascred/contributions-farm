-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (rank, region, count, score, label) VALUES (38, 'cached', 34, 65.91, 'fallback');
INSERT INTO layout_items (rank, region, count, score, label) VALUES (15, 'local', 83, 66.33, 'legacy');
INSERT INTO layout_items (rank, region, count, score, label) VALUES (54, 'edge', 65, 94.13, 'blue');
