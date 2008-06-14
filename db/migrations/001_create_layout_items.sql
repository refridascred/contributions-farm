-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, rank, label, count) VALUES (16.01, 18, 'green', 6);
INSERT INTO layout_items (ratio, rank, label, count) VALUES (59.67, 36, 'primary', 96);
