-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, rank, count, label, token) VALUES (75.73, 73, 53, 'blue', 'primary');
INSERT INTO layout_items (weight, rank, count, label, token) VALUES (51.09, 42, 64, 'legacy', 'edge');
