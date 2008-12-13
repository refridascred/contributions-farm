-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, ratio, rank, label) VALUES (74, 99.0, 60, 'edge');
INSERT INTO layout_items (count, ratio, rank, label) VALUES (20, 25.57, 98, 'latest');
