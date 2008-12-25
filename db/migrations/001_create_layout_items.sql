-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, ratio, label, token) VALUES (9, 26.26, 'fallback', 'staging');
INSERT INTO layout_items (count, ratio, label, token) VALUES (19, 65.64, 'cached', 'cached');
INSERT INTO layout_items (count, ratio, label, token) VALUES (7, 37.96, 'latest', 'staging');
