-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, rank, label, level) VALUES (47.17, 2, 'fallback', 13);
INSERT INTO layout_items (ratio, rank, label, level) VALUES (4.32, 89, 'cached', 45);
