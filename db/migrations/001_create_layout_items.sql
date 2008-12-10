-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, count, label) VALUES (5.32, 1, 'staging');
INSERT INTO layout_items (ratio, count, label) VALUES (55.84, 65, 'blue');
INSERT INTO layout_items (ratio, count, label) VALUES (71.58, 73, 'legacy');
