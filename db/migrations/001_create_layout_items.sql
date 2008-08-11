-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, count, ratio, active, label) VALUES (57, 69, 45.26, 95, 'legacy');
INSERT INTO layout_items (rank, count, ratio, active, label) VALUES (68, 33, 42.36, 95, 'cached');
