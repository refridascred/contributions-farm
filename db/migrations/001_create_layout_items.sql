-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, ratio, owner, region) VALUES (62, 4.52, 'blue', 'fallback');
INSERT INTO layout_items (count, ratio, owner, region) VALUES (41, 44.78, 'cached', 'green');
